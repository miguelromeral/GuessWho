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
        public SkinColour SkinColour { get; private set; }
        public List<OthersAttributes> Others { get; private set; }
        

        public Character(string n, Gender g, HairColour hc, HairStyle hs, EyesColour ec, SkinColour sc, List<OthersAttributes> o) 
        {
            Name = n;
            Gender = g;
            HairColour = hc;
            HairStyle = hs;
            EyesColour = ec;
            SkinColour = sc;
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

            // TODO

            //switch (Gender)
            //{
            //    case Gender.Male:
            //        res += "man";
            //        break;
            //    case Gender.Female:
            //        res += "woman";
            //        break;
            //}
            //res += ", ";

            //switch (HairStyle)
            //{
            //    case HairStyle.Curly:
            //        res += "curly ";
            //        break;
            //    case HairStyle.Bald:
            //        res += "bald";
            //        break;
            //    case HairStyle.LongHair:
            //        res += "long ";
            //        break;
            //}

            //switch (HairColour)
            //{
            //    case HairColour.Ginger:
            //        res += "ginger";
            //        break;
            //    case HairColour.Black:
            //        res += "black";
            //        break;
            //    case HairColour.White:
            //        res += "white";
            //        break;
            //    case HairColour.Brown:
            //        res += "brown";
            //        break;
            //    case HairColour.Blond:
            //        res += "blond";
            //        break;
            //}

            //switch (HairStyle)
            //{
            //    case HairStyle.Partition:
            //        res += " in partition hair";
            //        break;
            //    case HairStyle.Hat:
            //        res += " hair with hat";
            //        break;
            //    case HairStyle.Stuff:
            //        res += " hair with stuff";
            //        break;
            //    case HairStyle.Bald:
            //        break;
            //    default:
            //        res += " hair";
            //        break;
            //}
            //res += ", ";

            //switch (EyesColour)
            //{
            //    case EyesColour.Brown:
            //        res += "brown";
            //        break;
            //    case EyesColour.Blue:
            //        res += "blue";
            //        break;
            //}
            //res += " eyes";

            //switch (SkinColour)
            //{
            //    case SkinColour.Mustache:
            //        res += ", mustache";
            //        break;
            //    case SkinColour.Beard:
            //        res += ", beard";
            //        break;
            //    case SkinColour.BillyGoat:
            //        res += ", billy goat";
            //        break;
            //    case SkinColour.None:
            //    default:
            //        break;
            //}

            //if(Others != null)
            //{
            //    res += ", ";
            //    foreach(var o in Others)
            //    {
            //        switch (o)
            //        {
            //            case OthersAttributes.Glasses:
            //                res += "glasses, ";
            //                break;
            //            case OthersAttributes.EarRings:
            //                res += "ear rings, ";
            //                break;
            //            case OthersAttributes.BigMouth:
            //                res += "big mouth, ";
            //                break;
            //            case OthersAttributes.BigNose:
            //                res += "big nose, ";
            //                break;
            //            case OthersAttributes.RedCheeks:
            //                res += "red cheeks, ";
            //                break;
            //        }
            //    }
            //    res = res.Substring(0, res.Length - 2);
            //}

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

        public bool? AnswerQuestion(Question question)
        {
            bool? match = null;

            switch (question)
            {
                case Question.Man_Gender:
                    match = Gender == Gender.Male;
                    break;
                case Question.Woman_Gender:
                    match = Gender == Gender.Female;
                    break;

                case Question.Ginger_HairColour:
                    match = HairColour == HairColour.Ginger;
                    break;
                case Question.Black_HairColour:
                    match = HairColour == HairColour.Black;
                    break;
                case Question.WhiteHair_HairColour:
                    match = HairColour == HairColour.White;
                    break;
                case Question.BrownHair_HairColour:
                    match = HairColour == HairColour.Brown;
                    break;
                case Question.BlondHair_HairColour:
                    match = HairColour == HairColour.Blond;
                    break;

                case Question.PartitionHair_HairStyle:
                    match = HairStyle == HairStyle.Partition;
                    break;
                case Question.CurlyHair_HairStyle:
                    match = HairStyle == HairStyle.Curly;
                    break;
                case Question.HatHair_HairStyle:
                    match = HairStyle == HairStyle.Hat;
                    break;
                case Question.Bald_HairStyle:
                    match = HairStyle == HairStyle.Bald;
                    break;

                case Question.Brown_EyesColour:
                    match = EyesColour == EyesColour.Brown;
                    break;
                case Question.Blue_EyesColour:
                    match = EyesColour == EyesColour.Blue;
                    break;

                case Question.Black_SkinColour:
                    match = SkinColour == SkinColour.Black;
                    break;
                case Question.White_SkinColour:
                    match = SkinColour == SkinColour.White;
                    break;

                case Question.Glasses_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.Glasses);
                    break;
                case Question.EarRings_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.EarRings);
                    break;
                case Question.BigMouth_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.BigMouth);
                    break;
                case Question.BigNose_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.BigNose);
                    break;
                case Question.Mustache_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.Mustache);
                    break;
                case Question.Beard_OtherAttribute:
                    match = HasOtherAttribute(OthersAttributes.Beard);
                    break;

                default:
                    match = null;
                    break;
            }
            return match;
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
