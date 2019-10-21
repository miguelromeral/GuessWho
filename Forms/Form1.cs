using System;
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
    public partial class Form1 : Form
    {

        private FLogger Logger;
        public CGame Game;
        private CUser Current;
        private CUser Rival;
        private List<Character> Discards;

        public Form1()
        {
            InitializeComponent();

            Logger = new FLogger(this.infoText);
            Game = new CGame();
            Game.Logger = Logger;
            
            //CUser u1 = Game.AddPlayer("Miguel", Core.AICategory.Random, Color.FromArgb(255, 105, 105), pPlayer1, pb1);
            CUser u1 = Game.AddPlayer("Miguel", Core.AICategory.Human, Color.FromArgb(255, 105, 105), pPlayer1, pb1);
            CUser u2 = Game.AddPlayer("Javi", Core.AICategory.Random, Color.FromArgb(94, 164, 255), pPlayer2, pb2);
            
            u1.CreateButtons(lPlayer1);
            u2.CreateButtons(lPlayer2);
            
            ChangeUserTurn();

            Game.Start();
        }

        

        private void bPass_Click(object sender, EventArgs e)
        {
            if (!Game.HumanTurn)
            {
                Game.Play_Step();
                ChangeUserTurn();
            }
            else
            {
                MessageBox.Show("It is a player move. Select characters to discard.");
            }
        }

        void ChangeUserTurn()
        {
            Current = Game.Players[Game.Turn] as CUser;
            Rival = Game.GetRivalByPlayer(Current) as CUser;

            lTurnName.Text = Current.Name;
            
            UpdatePlayerQuestions(Current);

            Current.Panel.Visible = true;
            Current.Picture.Visible = true;

            // THIS IS OK, but now for debugging i'm allowed to cheat ;)
            //Rival.Panel.Visible = false;
            //Rival.Picture.Visible = false;
        }


        void UpdatePlayerQuestions(User user)
        {
            cbQuestion.Items.Clear();

            foreach(var q in user.Questions)
            {
                cbQuestion.Items.Add(Core.Game.GetFriendlyNameQuestion(q));
            }
            cbQuestion.Refresh();
        }

        private void bAsk_Click(object sender, EventArgs e)
        {
            Question question = Core.Game.GetQuestionByFriendlyName(cbQuestion.SelectedItem.ToString());

            if(question == Question.None)
            {
                MessageBox.Show("The question \"" + cbQuestion.SelectedItem.ToString() + "\" is not recognized.");
                return;
            }

            Game.PrintGame(true);

            Logger.WriteToLog(String.Format("{0} is asking {1}.", Current, Core.Game.GetFriendlyNameQuestion(question)));

            bool answer = Rival.Answer(question);
            Discards = Current.MakeMove(question, answer, false);


            Current.RemarkCharacters(Discards);
        }

        private void bDiscard_Click(object sender, EventArgs e)
        {
            if (Current.MakeMove(Current.SelectedCharacters()))
            {
                Game.ClearPlayerMove(Current);
                Game.ClearCheckedButtons(Current);
                Game.NextMove();
                Game.UpdatePlayersPanels();
                ChangeUserTurn();
            }
            else
            {
                MessageBox.Show("You have to select, at least, one character.");
            }
        }
    }
}
