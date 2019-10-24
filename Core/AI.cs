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
        private Random Seed { get; set; }


        public AI(User player, AICategory level)
        {
            this.Player = player;
            Level = level;
            Seed = new Random();
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
            
            AICategory level = (random ? (AICategory) Seed.Next(2, 4) : Level);

            Question choosen = Question.None;
            switch (level)
            {
                case AICategory.Brave:
                    choosen = GetQuestionBrave(0.35);
                    break;
                case AICategory.Clever:
                    choosen = GetSmallestProbability(GetProbabilities()).Question;
                    break;
                case AICategory.Medium:
                    choosen = GetQuestionByPercentage(0.3);
                    break;
                case AICategory.Easy:
                    choosen = GetQuestionByPercentage(0.65);
                    break;
                case AICategory.Mix:
                    choosen = ChooseQuestion(true);
                    break;
                case AICategory.Random:
                default:
                    choosen = Player.Questions[Seed.Next(Player.Questions.Count)];
                    break;
            }
            return choosen;
        }

        private Question GetQuestionBrave(double perc)
        {
            var probs = GetProbabilities().OrderByDescending(x => x.Percent).ToList();
            int max = Convert.ToInt32(Player.Questions.Count * perc);
            int index = Seed.Next(0, max);
            return probs[index].Question;
        }

        private Question GetQuestionByPercentage(double perc)
        {
            var probs = GetProbabilities();
            int max = Convert.ToInt32(Player.Questions.Count * perc);
            int index = Seed.Next(0, max);
            return probs[index].Question;
        }

        private Probability GetSmallestProbability(List<Probability> probabilities, bool random = true)
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
        

        private List<Probability> GetProbabilities()
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

        private double OptimizedAlgorithm(int m, int l)
        {
            double matches = (double)m;
            double left = (double)l;
            double remainders = left - matches;
            
            return matches * matches / left + remainders * remainders / left;
        }
    }
}
