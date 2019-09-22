using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AI
    {
        public User player;
        public AICategory Level { get; set; }


        public AI(User player, AICategory level)
        {
            this.player = player;
            Level = level;
        }


        public bool ShouldDoIAnswer(User rival)
        {
            bool answ = (player.Remainders == 1);
            return answ;
        }

        public Character GetChoosen()
        {
            foreach(var c in player.Board.Characters)
            {
                if (!c.Discarded)
                    return c;
            }
            return null;
        }

        public Question? ChooseQuestion()
        {
            if (player.Questions == null || player.Questions.Count == 0)
                return null;

            Question? choosen = null;
            switch (Level)
            {
                case AICategory.Random:
                    choosen = player.Questions[new Random().Next(player.Questions.Count)];
                    break;
                default:
                    break;
            }
            return choosen;
        }
    }
}
