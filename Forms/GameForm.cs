﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Forms
{
    public partial class GameForm : Form
    {

        private FLogger Logger;
        public CGame Game;
        private CUser Current;
        private CUser Rival;
        private List<Character> Discards;

        private bool asked { get; set; }

        public GameForm(string user1, string user2, Core.AICategory ai1, Core.AICategory ai2, Color c1, Color c2, int t)
        {
            InitializeComponent();

            Logger = new FLogger(this.infoText);
            Game = new CGame(t);
            Game.Logger = Logger;
            
            CUser u1 = Game.AddPlayer(user1, ai1, c1, pPlayer1, pb1, lCount1);
            CUser u2 = Game.AddPlayer(user2, ai2, c2, pPlayer2, pb2, lCount2);

            this.Text = user1 + " vs. " + user2 + " - Guess Who?";

            u1.CreateButtons(lPlayer1);
            u2.CreateButtons(lPlayer2);

            lPlayer1.ForeColor = c1;
            lCount1.ForeColor = c1;
            lPlayer2.ForeColor = c2;
            lCount2.ForeColor = c2;

            pb1.Visible = false;
            pb2.Visible = false;

            ChangeUserTurn();

            UpdatePlayerQuestions(Current);
            Game.Start();
            DisplayAllPanels();
        }

        void EnableButtons()
        {
            if (Game.Finished)
            {
                bPass.Enabled = false;
                bResolve.Enabled = false;
                bDiscard.Enabled = false;
                bAsk.Enabled = false;
            }
            else
            {
                bool human = Current.Inteligence.Level == AICategory.Human;
                bPass.Enabled = !human;
                bResolve.Enabled = human;
                bDiscard.Enabled = human;
                bAsk.Enabled = !asked && human;
            }
        }

        private void bPass_Click(object sender, EventArgs e)
        {
            if (!Game.HumanTurn)
            {
                Game.Play_Step();
                ChangeUserTurn();
                if (Game.Finished)
                {
                    DisplayAllPanels(true);
                    EnableButtons();
                    MessageBox.Show(Game.Winner + " has already won the game!");
                }
            }
            else
            {
                MessageBox.Show("It is a player move. Select characters to discard.");
            }
            DisplayAllPanels();
        }

        void ChangeUserTurn()
        {
            Current = Game.Players[Game.Turn] as CUser;
            Rival = Game.GetRivalByPlayer(Current) as CUser;

            Current.Count.Text = "" + Current.Remainders;
            Rival.Count.Text = "" + Rival.Remainders;
        }


        void UpdatePlayerQuestions(User user)
        {
            cbQuestion.Items.Clear();

            foreach (var q in user.Questions)
            {
                cbQuestion.Items.Add(Core.Game.GetFriendlyNameQuestion(q));
            }
            cbQuestion.Refresh();
        }

        private void bAsk_Click(object sender, EventArgs e)
        {
            if (asked)
            {
                MessageBox.Show("You've already asked something.");
                return;
            }

            if(cbQuestion.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a question to ask.");
                return;
            }

            Question question = Core.Game.GetQuestionByFriendlyName(cbQuestion.SelectedItem.ToString());

            if(question == Question.None)
            {
                MessageBox.Show("The question \"" + cbQuestion.SelectedItem.ToString() + "\" is not recognized.");
                return;
            }

            Current.Questions.Remove(question);
            //Game.PrintGame(true);

            Logger.WriteToLog(String.Format("{0} is asking {1}.", Current, Core.Game.GetFriendlyNameQuestion(question)));

            bool answer = Rival.Answer(question);
            Discards = Current.MakeMove(question, answer, false);


            Current.RemarkCharacters(Discards);
            asked = true;
            EnableButtons();
        }

        private void bDiscard_Click(object sender, EventArgs e)
        {   
            if (Current.MakeMove(Current.SelectedCharacters()))
            {
                NextMove();
            }
            else
            {
                MessageBox.Show("You have to select, at least, one of your characters.");
            }

            DisplayAllPanels();
        }

        void DisplayAllPanels(bool showall = false)
        {
            if (showall)
            {
                Current.Panel.Visible = true;
                Current.Picture.Visible = true;
                Rival.Panel.Visible = true;
                Rival.Picture.Visible = true;
                return;
            }
            
            // Two humans
            if(Rival.Inteligence.Level == Current.Inteligence.Level && Rival.Inteligence.Level == AICategory.Human)
            {
                Rival.Panel.Visible = false;
                Rival.Picture.Visible = false;
                if (Game.TwoHumanPlayers)
                {
                    MessageBox.Show("Please, pass the PC to " + Current + " before press OK, please.");
                }
                Current.Panel.Visible = true;
                Current.Picture.Visible = true;

                EnableButtons();
            }
            else
            {
                // Two PC
                if (Current.Inteligence.Level != AICategory.Human && Rival.Inteligence.Level != AICategory.Human)
                {
                    Current.Panel.Visible = true;
                    Current.Picture.Visible = true;
                    Rival.Panel.Visible = true;
                    Rival.Picture.Visible = true;

                    bPass.Enabled = true;
                    bResolve.Enabled = false;
                    bDiscard.Enabled = false;
                    bAsk.Enabled = false;
                }
                else
                {
                    if(Current.Inteligence.Level == AICategory.Human)
                    {
                        Current.Panel.Visible = true;
                        Current.Picture.Visible = true;
                    }
                    else
                    {
                        Current.Panel.Visible = false;
                        Current.Picture.Visible = false;
                    }
                    if (Rival.Inteligence.Level == AICategory.Human)
                    {
                        Rival.Panel.Visible = true;
                        Rival.Picture.Visible = true;
                    }
                    else
                    {
                        Rival.Panel.Visible = false;
                        Rival.Picture.Visible = false;
                    }
                    EnableButtons();
                }
            }
        }

        void NextMove()
        {
            asked = false;
            UpdatePlayerQuestions(Current);
            Game.ClearPlayerMove(Current);
            Game.ClearCheckedButtons(Current);
            Game.NextMove();
            Game.UpdatePlayersPanels();
            ChangeUserTurn();
        }

        private void bResolve_Click(object sender, EventArgs e)
        {
            var selected = Current.SelectedCharacters();
            if(selected == null || selected.Count != 1)
            {
                MessageBox.Show("You must select only one character to resolve.");
                return;
            }

            var solution = selected.FirstOrDefault();
            Current.Choosen = solution;

            if(Current.Choosen.Name == Rival.Secret.Name)
            {
                DisplayAllPanels(true);
                EnableButtons();
                MessageBox.Show("You won the game!");
            }
            else
            {
                MessageBox.Show("You're wrong. Best luck next time!");
                NextMove();
                DisplayAllPanels();
            }
        }
    }
}
