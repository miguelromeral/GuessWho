using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Board
    {
        public List<Character> Characters { get; private set; }
        

        public Board()
        {
            Characters = new List<Character>();
            FillBoard();
        }

        internal void FillBoard()
        {
            Characters.Clear();
            Characters.Add(new Character(Names.Stephen.ToString(), Gender.Male, Hair.Ginger));
            Characters.Add(new Character(Names.Isabelle.ToString(), Gender.Female, Hair.Ginger));
            //Characters.Add(new Character("Max", Gender.Male, Hair.Black));
        }
        

        internal int Discard(Question q, bool answer, bool perform = false)
        {
            int discards = 0;
            switch (q)
            {
                case Question.Man:
                    foreach (var c in Characters)
                    {
                        if (c.Discarded)
                            continue;
                        
                        if (c.Gender == Gender.Male && !answer ||
                            c.Gender != Gender.Male && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                    }
                    break;
                case Question.Woman:
                    foreach(var c in Characters)
                    {
                        if (c.Discarded)
                            continue;

                        if (c.Gender == Gender.Female && !answer ||
                            c.Gender != Gender.Female && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                    }
                    break;
                default:
                    return -1;
            }
            return discards;
        }

        private void DiscardSingle(Character c, bool perform)
        {
            if (perform)
                c.Off();
        }
    }
}
