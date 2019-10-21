using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Forms
{
    public class CGame : Game
    {
        public CGame() : base()
        {

        }

        public CUser AddPlayer(string name, AICategory level, Color c, Panel panel, PictureBox picture)
        {
            try
            {
                if (Players.Count >= MAX_PLAYERS)
                    return null;

                CUser u = new CUser(name, level, c, panel)
                {
                    Picture = picture,
                };
                u.SetSecret(GetRandomSolution(u));
                u.Board.Logger = Logger;
                Players.Add(u);
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Play_Step()
        {
            if (Winner != null)
            {
                Logger.WriteToLog(String.Format("{0} has won in {1} moves!", Winner, (_turn + 1)));
                return true;
            }

            bool endgame = false;
            User current, rival;

            current = Players[Turn];
            rival = GetRivalByPlayer(current);
            PrintGame(true);
            // Make Question
            Question question = current.Inteligence.ChooseQuestion();
            if (question == Question.None)
                goto endmove;

            Logger.WriteToLog(String.Format("{0} is asking {1}.", current, GetFriendlyNameQuestion(question)));
            MakeQuestion(current, question);

            // Choose selected
            if (current.Inteligence.ShouldDoIAnswer(rival))
            {
                current.Choosen = current.Inteligence.GetChoosen();
                if (current.Choosen.Name == rival.Secret.Name)
                    endgame = true;
            }


        endmove:
            if (!endgame)
            {
                ClearPlayerMove(current);
                NextMove();
            }
            UpdatePlayersPanels();
            return false;
        }


        public void UpdatePlayersPanels()
        {
            foreach(var p in Players)
            {
                var ps = p as CUser;
                ps.UpdateButtons();
            }
        }

        public void ClearCheckedButtons(CUser user)
        {
            foreach(var b in user.Buttons)
            {
                if (b.Checked)
                    b.Checked = false;
            }
        }
    }
}
