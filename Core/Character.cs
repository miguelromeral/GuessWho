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

        #region OVERLOADED FUNCTIONS
        public static bool operator ==(Character c1, Character c2)
        {
            if (c1.Name == c2.Name)
                return true;
            else
                return false;
        }
        
        public static bool operator !=(Character c1, Character c2)
        {
            if (c1.Name != c2.Name)
                return true;
            else
                return false;
        }
        #endregion
    }
}
