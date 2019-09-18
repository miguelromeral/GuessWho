using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Character
    {
        public bool Discarded { get; private set; }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public Hair Hair { get; private set; }


        public Character(string n, Gender g, Hair h)
        {
            Name = n;
            Gender = g;
            Hair = h;
        }



        internal void Off()
        {
            Discarded = true;
        }
        internal void On()
        {
            Discarded = false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
