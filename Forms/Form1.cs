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

        public Form1()
        {
            InitializeComponent();

            Logger = new FLogger(this.infoText);
            Game = new CGame();
            Game.Logger = Logger;
            
            CUser u1 = Game.AddPlayer("Miguel", Core.AICategory.Human, Color.FromArgb(255, 105, 105), pPlayer1);
            CUser u2 = Game.AddPlayer("Javi", Core.AICategory.Random, Color.FromArgb(94, 164, 255), pPlayer2);
            
            u1.CreateButtons(lPlayer1);
            u2.CreateButtons(lPlayer2);

            Game.Start();
        }

        

        private void bPass_Click(object sender, EventArgs e)
        {
            Game.Play_Step();
        }


        
    }
}
