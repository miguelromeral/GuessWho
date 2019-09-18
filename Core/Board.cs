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

        public void FillBoard()
        {
            Characters.Clear();
            Characters.Add(new Character("Stephen", Gender.Male));
            Characters.Add(new Character("Isabelle", Gender.Female));
        }


        public Character GetRandomCharacter()
        {
            try
            {
                return Characters.ElementAt(new Random().Next(Characters.Count));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
