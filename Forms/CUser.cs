﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Forms
{
    public class CUser : User
    {
        public Color Color { get; set; }
        public List<CCheckBox> Buttons { get; set; }

        public Form1 Form { get; set; }

        public Panel Panel { get; set; }

        public CUser(string n, AICategory level, Color color, Panel panel) : base(n, level)
        {
            Color = color;
            Panel = panel;
            Buttons = new List<CCheckBox>();
        }

        public void CreateButtons(Label lPlayer)
        {
            float perc = 1;
            int width = (int)(90 * CCheckBox.PERCENTAGE);
            int height = (int)(130 * CCheckBox.PERCENTAGE);

            lPlayer.Text = Name;

            foreach (var n in Enum.GetNames(typeof(Names)))
            {
                Image myimage = GUIUtilities.GetImageFromName(n);

                CCheckBox b = new CCheckBox()
                {
                    Player = this,
                    BackColor = Color,
                    Color = Color,
                    Character = Board.GetCharacterByName(n),
                    Image = myimage,
                    Name = Name + "_" + n,
                    BackgroundImage = myimage,
                    Width = width,
                    Height = height,
                    Appearance = Appearance.Button
                };

                if(Inteligence.Level == AICategory.Human)
                {
                    b.CheckedChanged += new System.EventHandler(b.SetTransparency);
                }
                else
                {
                    b.Enabled = false;
                }
                b.BackgroundImage = new Bitmap(b.BackgroundImage, b.Width, b.Height);
                Buttons.Add(b);
                Panel.Controls.Add(b);
            }
        }
    }
}
