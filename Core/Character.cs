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

        public HairColour HairColour { get; private set; }
        public HairStyle HairStyle { get; private set; }
        public EyesColour EyesColour { get; private set; }
        public FacialHair FacialHair { get; private set; }
        public List<OthersAttributes> Others { get; private set; }
        

        public Character(string n, Gender g, HairColour hc, HairStyle hs, EyesColour ec, FacialHair fh, List<OthersAttributes> o) 
        {
            Name = n;
            Gender = g;
            HairColour = hc;
            HairStyle = hs;
            EyesColour = ec;
            FacialHair = fh;
            Others = o;
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
        
        public string GetAttributes(bool shortsize = true)
        {
            string res = "";

            switch (Gender)
            {
                case Gender.Male:
                    res += "man";
                    break;
                case Gender.Female:
                    res += "woman";
                    break;
            }
            res += ", ";

            switch (HairStyle)
            {
                case HairStyle.Curly:
                    res += "curly ";
                    break;
                case HairStyle.Bald:
                    res += "bald";
                    break;
                case HairStyle.LongHair:
                    res += "long ";
                    break;
            }

            switch (HairColour)
            {
                case HairColour.Ginger:
                    res += "ginger";
                    break;
                case HairColour.Black:
                    res += "black";
                    break;
                case HairColour.White:
                    res += "white";
                    break;
                case HairColour.Brown:
                    res += "brown";
                    break;
                case HairColour.Blond:
                    res += "blond";
                    break;
            }

            switch (HairStyle)
            {
                case HairStyle.Partition:
                    res += " in partition hair";
                    break;
                case HairStyle.Hat:
                    res += " hair with hat";
                    break;
                case HairStyle.Stuff:
                    res += " hair with stuff";
                    break;
                case HairStyle.Bald:
                    break;
                default:
                    res += " hair";
                    break;
            }
            res += ", ";

            switch (EyesColour)
            {
                case EyesColour.Brown:
                    res += "brown";
                    break;
                case EyesColour.Blue:
                    res += "blue";
                    break;
            }
            res += " eyes";

            switch (FacialHair)
            {
                case FacialHair.Mustache:
                    res += ", mustache";
                    break;
                case FacialHair.Beard:
                    res += ", beard";
                    break;
                case FacialHair.BillyGoat:
                    res += ", billy goat";
                    break;
                case FacialHair.None:
                default:
                    break;
            }

            if(Others != null)
            {
                res += ", ";
                foreach(var o in Others)
                {
                    switch (o)
                    {
                        case OthersAttributes.Glasses:
                            res += "glasses, ";
                            break;
                        case OthersAttributes.EarRings:
                            res += "ear rings, ";
                            break;
                        case OthersAttributes.BigMouth:
                            res += "big mouth, ";
                            break;
                        case OthersAttributes.BigNose:
                            res += "big nose, ";
                            break;
                        case OthersAttributes.RedCheeks:
                            res += "red cheeks, ";
                            break;
                    }
                }
                res = res.Substring(0, res.Length - 2);
            }

            return res;
        }

        public bool HasOtherAttribute(OthersAttributes other)
        {
            if (Others == null)
                return false;

            foreach(var o in Others)
            {
                if (o == other)
                    return true;
            }
            return false;
        }

        //#region OVERLOADED FUNCTIONS
        //public static bool operator ==(Character c1, Character c2)
        //{
        //    /*if (c1 == null && c2 == null)
        //        return true;
        //    if (c1 == null || c2 == null)
        //        return false;*/

        //    if (c1.Name == c2.Name)
        //        return true;
        //    else
        //        return false;
        //}
        
        //public static bool operator !=(Character c1, Character c2)
        //{
        //    /*if (c1 == null && c2 == null)
        //        return false;
        //    if (c1 == null || c2 == null)
        //        return true;*/
                
        //    if (c1.Name != c2.Name)
        //        return true;
        //    else
        //        return false;
        //}
        //#endregion
    }
}
