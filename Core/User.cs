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

        public int LastNumer;

        public void SetDiscards(int discards)
        {
            int half = (int) (LastNumer / 2);
            if(discards > half && Inteligence.Level == AICategory.Brave)
            {
                Inteligence.Level = AICategory.Clever;
            }
            LastNumer = Remainders;
        }

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
            LastNumer = Board.Characters.Count;
        }

        private void FillQuestions()
        {
            Questions = new List<Question>();
            foreach (var q in (Question[])Enum.GetValues(typeof(Question)))
                if(q != Question.None)
                    Questions.Add(q);
        }

        public void SetSecret(Character c)
        {
            Secret = c;
            Board.DiscardSingle(c);
        }


        public bool Answer(Question q)
        {
            var answer = Secret.AnswerQuestion(q);
            if (answer == null)
                return false;
            return (bool) answer;
        }

        public List<Character> MakeMove(Question q, bool answer, bool performs = true)
        {
            return Board.Discard(q, answer, performs);
        }
        public bool MakeMove(List<Character> Discards)
        {
            return Board.Discard(Discards);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
