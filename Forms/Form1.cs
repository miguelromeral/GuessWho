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
        public Game Game;
        private List<CheckBox> bPlayer1;

        public Form1()
        {
            InitializeComponent();

            Logger = new FLogger(this.infoText);
            Game = new Game();
            Game.Logger = Logger;

            var u1 = Game.AddPlayer("Miguel", Core.AICategory.Random);
            var u2 = Game.AddPlayer("Javi", Core.AICategory.Random);

            CreateButtons(lPlayer1, pPlayer1, bPlayer1, u1);

            Game.Start();
        }

        private void CreateButtons(Label lPlayer, Panel pPlayer, List<CheckBox> bPlayer, User user)
        {
            bPlayer = new List<CheckBox>();
            float perc = 1;
            int width = (int)(90 * CCheckBox.PERCENTAGE);
            int height = (int)(130 * CCheckBox.PERCENTAGE);

            foreach (var n in Enum.GetNames(typeof(Names)))
            {
                Image myimage =  GUIUtilities.GetImageFromName(n);

                CCheckBox b = new CCheckBox()
                {
                    Player = user,
                    Character = user.Board.GetCharacterByName(n),
                    Image = myimage,
                    Name = user.Name + "_" + n,
                    BackgroundImage = myimage,
                    Width = width,
                    Height = height,
                    Appearance = Appearance.Button
                };
                b.CheckedChanged += new System.EventHandler(b.SetTransparency);
                b.BackgroundImage = new Bitmap(b.BackgroundImage, b.Width, b.Height);
                bPlayer.Add(b);
                pPlayer.Controls.Add(b);
            }
        }

        private void bPass_Click(object sender, EventArgs e)
        {
            Game.Play_Step();
        }


        
    }
}
