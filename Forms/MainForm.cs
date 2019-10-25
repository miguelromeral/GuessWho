using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {

        List<Core.AICategory> aielements;

        public MainForm()
        {
            InitializeComponent();

            aielements = new List<Core.AICategory>();

            foreach (var l in (Core.AICategory[])Enum.GetValues(typeof(Core.AICategory)))
            {
                aielements.Add(l);
            }

            AddItemsComboBox(cbUser1);
            cbUser1.SelectedIndex = 0;
            AddItemsComboBox(cbUser2);
            cbUser2.SelectedIndex = 2;

            tbUser1.Text = "Player 1";
            tbUser2.Text = "Player 2";

            AddItemsComboBoxUsers();
            cbStart.SelectedIndex = 2;

            bColor1.BackColor = Color.FromArgb(255, 105, 105);
            bColor2.BackColor = Color.FromArgb(94, 164, 255);
        }

        void AddItemsComboBox(ComboBox combo)
        {
            combo.Items.Clear();
            foreach(var l in aielements)
            {
                combo.Items.Add(l);
            }
        }

        private string randomTurn = "Randomly";

        void AddItemsComboBoxUsers()
        {
            cbStart.Items.Clear();
            cbStart.Items.Add(tbUser1.Text);
            cbStart.Items.Add(tbUser2.Text);
            cbStart.Items.Add(randomTurn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user1 = tbUser1.Text;
            string user2 = tbUser2.Text;

            if (String.IsNullOrEmpty(user1))
            {
                MessageBox.Show("You must set a name for Player 1");
                return;
            }
            if (String.IsNullOrEmpty(user2))
            {
                MessageBox.Show("You must set a name for Player 2");
                return;
            }

            if (cbUser1.SelectedIndex == -1)
            {
                MessageBox.Show("You must set a hard level for Player 1");
                return;
            }
            if (cbUser2.SelectedIndex == -1)
            {
                MessageBox.Show("You must set a hard level for Player 1");
                return;
            }

            Core.AICategory ai1 = (Core.AICategory) cbUser1.SelectedItem;
            Core.AICategory ai2 = (Core.AICategory) cbUser2.SelectedItem;

            int t = 0;

            string turn = (string) cbStart.SelectedItem;
            if (tbUser1.Text == turn)
                t = 0;
            else if (tbUser2.Text == turn)
                t = 1;
            else
                t = 2;

            var f = new Form1(user1, user2, ai1, ai2, bColor1.BackColor, bColor2.BackColor, t);
            f.Show();
        }

        private void bColor1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                bColor1.BackColor = colorDialog1.Color;
                bColor1.Text = colorDialog1.Color.ToString();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bColor2_Click(object sender, EventArgs e)
        {

            DialogResult result = colorDialog2.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                bColor2.BackColor = colorDialog2.Color;
                bColor2.Text = colorDialog2.Color.ToString();
            }
        }

        private void cbUser1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_SelectedIndexChanged(cbUser1, bColor1);
        }

        private void cbUser2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_SelectedIndexChanged(cbUser2, bColor2);
        }


        private void cb_SelectedIndexChanged(ComboBox combobox, Button button)
        {
            if (combobox.SelectedItem != null)
            {
                var el = (Core.AICategory)combobox.SelectedItem;
                if (el == Core.AICategory.Human)
                {
                    button.Visible = true;
                }
                else
                {
                    button.Visible = false;
                    button.BackColor = Color.Gray;
                }
            }
        }

        private void tbUser1_KeyUp(object sender, KeyEventArgs e)
        {
            AddItemsComboBoxUsers();
        }

        private void tbUser2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddItemsComboBoxUsers();
        }

        private void tbUser2_KeyUp(object sender, KeyEventArgs e)
        {
            AddItemsComboBoxUsers();
        }
    }
}
