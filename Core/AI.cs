using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AI
    {
        public User Player;
        public AICategory Level { get; set; }


        public AI(User player, AICategory level)
        {
            this.Player = player;
            Level = level;
        }


        public bool ShouldDoIAnswer(User rival)
        {
            bool answ = (Player.Remainders == 1);
            return answ;
        }

        public Character GetChoosen()
        {
            foreach(var c in Player.Board.Characters)
            {
                if (!c.Discarded)
                    return c;
            }
            return null;
        }

        public Question ChooseQuestion(bool random = false)
        {
            if (Player.Questions == null || Player.Questions.Count == 0)
                return Question.None;

            var seed = new Random();

            AICategory level = (random ? (AICategory) seed.Next(2, 4) : Level);

            Question choosen = Question.None;
            switch (level)
            {
                case AICategory.Clever:
                    choosen = GetOptimizedQuestion();
                    break;
                case AICategory.Mix:
                    choosen = ChooseQuestion(true);
                    break;
                case AICategory.Random:
                default:
                    choosen = Player.Questions[seed.Next(Player.Questions.Count)];
                    break;
            }
            return choosen;
        }

        public Question GetOptimizedQuestion()
        {
            return GetSmallestProbability(GetProbabilities(), false).Question;
        }

        public Probability GetSmallestProbability(List<Probability> probabilities, bool random)
        {
            double smallest = 25;
            List<Probability> sprobs = new List<Probability>();

            foreach(var p in probabilities)
            {
                if(p.Percent < smallest)
                {
                    smallest = p.Percent;
                    sprobs.Clear();
                }
                if(p.Percent <= smallest)
                {
                    sprobs.Add(p);
                }
            }

            return sprobs[(random ? new Random().Next(sprobs.Count) : 0)];
        }


        public struct Probability
        {
            public Question Question;
            public double Percent;

            public Probability(Question q, double p)
            {
                Question = q;
                Percent = p;
            }
        }

        public List<Probability> GetProbabilities()
        {
            List<Probability> list = new List<Probability>();
            int left = Player.Remainders;

            foreach(var q in Player.Questions)
            {
                int matches = Player.Board.Discard(q, false, false).Count;
                double prob = OptimizedAlgorithm(matches, left);
                Probability tuple = new Probability(q, prob);
                list.Add(tuple);
            }

            return list;
        }

        public double OptimizedAlgorithm(int m, int l)
        {
            double matches = (double)m;
            double left = (double)l;
            double remainders = left - matches;
            
            return matches * matches / left + remainders * remainders / left;
        }
    }
}
