using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {
        public string Name { get; private set; }
        public Character Secret { get; private set; }
        public Character Choosen { get; set; }
        public Board Board { get; private set; }
        public List<Question> Questions { get; private set; }
        public AI Inteligence { get; private set; }

        public int Remainders {
            get {
                if (Board.Characters == null)
                    return -1;

                int count = 0;
                foreach(var c in Board.Characters)
                {
                    if (!c.Discarded)
                        count++;
                }
                return count;
            }
        }

        public User(string n, AICategory level)
        {
            Name = n;
            Inteligence = new AI(this, level);
            Board = new Board();
            FillQuestions();
        }

        private void FillQuestions()
        {
            Questions = new List<Question>();
            foreach (var q in (Question[])Enum.GetValues(typeof(Question)))
                Questions.Add(q);
        }

        public void SetSecret(Character c)
        {
            Secret = c;
        }


        public bool Answer(Question q)
        {
            switch (q)
            {
                case Question.Man_Gender:
                    return Secret.Gender == Gender.Male;
                case Question.Woman_Gender:
                    return Secret.Gender == Gender.Female;
                case Question.Ginger_HairColour:
                    return Secret.HairColour == HairColour.Ginger;
                case Question.Black_HairColour:
                    return Secret.HairColour == HairColour.Black;
                case Question.WhiteHair_HairColour:
                    return Secret.HairColour == HairColour.White;
                case Question.BrownHair_HairColour:
                    return Secret.HairColour == HairColour.Brown;
                case Question.BlondHair_HairColour:
                    return Secret.HairColour == HairColour.Blond;

                default:
                    return false;
            }
        }

        public bool MakeMove(Question q, bool answer)
        {
            int discards = Board.Discard(q, answer, true);

            if (discards == -1)
                return false;

            return true;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
