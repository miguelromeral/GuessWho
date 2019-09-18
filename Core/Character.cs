using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Character
    {
        public bool Visible { get; private set; }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }



        public Character(string n, Gender g)
        {
            Name = n;
            Gender = g;
        }



        public void VisibleOff()
        {
            Visible = false;
        }
        public void VisibleOn()
        {
            Visible = true;
        }
    }
}
