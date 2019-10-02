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
            
            CUser u1 = Game.AddPlayer("Miguel", Core.AICategory.Random, Color.FromArgb(255, 105, 105), pPlayer1, pb1);
            //CUser u1 = Game.AddPlayer("Miguel", Core.AICategory.Human, Color.FromArgb(255, 105, 105), pPlayer1, pb1);
            CUser u2 = Game.AddPlayer("Javi", Core.AICategory.Random, Color.FromArgb(94, 164, 255), pPlayer2, pb2);
            
            u1.CreateButtons(lPlayer1);
            u2.CreateButtons(lPlayer2);

            UpdatePlayerQuestions(Game.Players[0], cbQuestion);

            Game.Start();
        }

        

        private void bPass_Click(object sender, EventArgs e)
        {
            if (!Game.HumanTurn)
            {
                Game.Play_Step();
                UpdatePlayerQuestions(Game.Players[0], cbQuestion);
            }
        }


        void UpdatePlayerQuestions(User user, ComboBox combo)
        {
            combo.Items.Clear();

            foreach(var q in user.Questions)
            {
                combo.Items.Add(Core.Game.GetFriendlyNameQuestion(q));
            }
        }

        private void bAsk_Click(object sender, EventArgs e)
        {
            Question question = Core.Game.GetQuestionByFriendlyName(cbQuestion.SelectedItem.ToString());

            if(question == Question.None)
            {
                MessageBox.Show("The question \"" + cbQuestion.SelectedItem.ToString() + "\" is not recognized.");
                return;
            }
            Game.PlayQuestion_User(question);
            User rival = Game.Players[1];
            bool answer = rival.Answer(question);

            CUser me = Game.Players[0] as CUser;
            me.RemarkCharacters(question, answer);
        }
    }
}
