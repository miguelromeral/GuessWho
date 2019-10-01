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

        public CUser AddPlayer(string name, AICategory level, Color c, Panel panel)
        {
            try
            {
                if (Players.Count >= MAX_PLAYERS)
                    return null;

                CUser u = new CUser(name, level, c, panel);
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
    }
}
