using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Names
    {
        Stephen,
        Isabelle,
        //Max,
    }

    public enum Gender
    {
        Male,
        Female,
    }

    public enum Hair
    {
        Ginger,
        Black,
    }

    // http://chalkdustmagazine.com/blog/cracking-guess-board-game/
    public enum Question
    {
        // Gender
        Man,
        Woman,

        // Hair
        GingerHair,
        BlackHair,
    }


    public enum AICategory
    {
        Human = 0,
        Random
    }
}
