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
    public class CCheckBox : CheckBox
    {
        public static double PERCENTAGE = 1;

        public User Player { get; set; }
        public Character Character { get; set; }
        public Image Image { get; set; }
        public Color Color { get; set; }



        public void SetTransparency(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                cb.BackColor = Color.Transparent;
                cb.BackgroundImage = GUIUtilities.SetImageOpacity(Image, PERCENTAGE, 0.5F);
            }
            else
            {
                cb.BackColor = Color;
                cb.BackgroundImage = GUIUtilities.SetImageOpacity(Image, PERCENTAGE, 1F);
            }
        }
    }
}
