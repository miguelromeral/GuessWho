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


        public User(string n)
        {
            Name = n;
            Board = new Board();
            SetSelected();
        }


        public void SetSelected()
        {
            Secret = Board.GetRandomCharacter();
        }
    }
}
