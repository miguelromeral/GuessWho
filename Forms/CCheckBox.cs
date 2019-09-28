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
    internal class CCheckBox : CheckBox
    {
        public static double PERCENTAGE = 1;

        public User Player { get; set; }
        public Character Character { get; set; }
        public Image Image { get; set; }



        public void SetTransparency(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                cb.BackColor = Color.Transparent;
                // Se está cogiendo la imagen original
                cb.BackgroundImage = GUIUtilities.SetImageOpacity(Image, PERCENTAGE, 0.5F);
            }
            else
            {
                cb.BackgroundImage = GUIUtilities.SetImageOpacity(Image, PERCENTAGE, 1F);
            }
        }
    }
}
