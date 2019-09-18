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
        public Board Board { get; private set; }
        public List<Question> Questions { get; private set; }


        public User(string n)
        {
            Name = n;
            Board = new Board();
            SetSelected();
            FillQuestions();
        }

        private void FillQuestions()
        {
            Questions = new List<Question>();
            foreach (var q in (Question[])Enum.GetValues(typeof(Question)))
                Questions.Add(q);
        }

        internal void SetSelected()
        {
            Secret = Board.GetRandomCharacter();
        }


        public bool Answer(Question q)
        {
            switch (q)
            {
                case Question.Man:
                    return Secret.Gender == Gender.Male;
                case Question.Woman:
                    return Secret.Gender == Gender.Female;
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
