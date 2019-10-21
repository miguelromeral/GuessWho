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
        public ILogger Logger { get; set; }

        public Board()
        {
            Characters = new List<Character>();
            FillBoard();
        }

        internal void FillBoard()
        {
            Characters.Clear();
            Characters.Add(new Character(
                Names.Anne.ToString(),
                Gender.Female,
                HairColour.White,
                HairStyle.Curly,
                EyesColour.Blue,
                FacialHair.None,
                new[] {
                    OthersAttributes.EarRings,
                    OthersAttributes.Glasses
                }.ToList()));
            Characters.Add(new Character(
                Names.Roger.ToString(),
                Gender.Male,
                HairColour.None,
                HairStyle.Bald,
                EyesColour.Brown,
                FacialHair.Beard,
                null));
            Characters.Add(new Character(
                Names.Paul.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Partition,
                EyesColour.Brown,
                FacialHair.BillyGoat,
                new[]
                {
                    OthersAttributes.Glasses
                }.ToList()));
            Characters.Add(new Character(
                Names.Frank.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Hat,
                EyesColour.Brown,
                FacialHair.None,
                new[] {
                    OthersAttributes.BigMouth,
                    OthersAttributes.BigNose,
                }.ToList()));
            Characters.Add(new Character(
                Names.Max.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Curly,
                EyesColour.Brown,
                FacialHair.Beard,
                new[] {
                    OthersAttributes.BigMouth
                }.ToList()));
            Characters.Add(new Character(
                Names.Philippe.ToString(),
                Gender.Male,
                HairColour.None,
                HairStyle.Bald,
                EyesColour.Brown,
                FacialHair.Beard,
                null));
            Characters.Add(new Character(
                Names.Katrin.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Partition,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.EarRings }.ToList()));
            Characters.Add(new Character(
                Names.Daniel.ToString(),
                Gender.Male,
                HairColour.None,
                HairStyle.Bald,
                EyesColour.Blue,
                FacialHair.None,
                new[] { OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Bernard.ToString(),
                Gender.Male,
                HairColour.Brown,
                HairStyle.Hat,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigNose }.ToList()));
            Characters.Add(new Character(
                Names.Hans.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Brown,
                FacialHair.Mustache,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Herman.ToString(),
                Gender.Male,
                HairColour.None,
                HairStyle.Bald,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigNose }.ToList()));
            Characters.Add(new Character(
                Names.Joe.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Blue,
                FacialHair.None,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Theo.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Curly,
                EyesColour.Brown,
                FacialHair.Mustache,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Sarah.ToString(),
                Gender.Female,
                HairColour.Blond,
                HairStyle.Hat,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.EarRings, OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Marta.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Hat,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.EarRings, OthersAttributes.RedCheeks }.ToList()));
            Characters.Add(new Character(
                Names.Lucas.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Curly,
                EyesColour.Brown,
                FacialHair.Beard,
                null));
            Characters.Add(new Character(
                Names.Carmen.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Partition,
                EyesColour.Brown,
                FacialHair.None,
                null));
            Characters.Add(new Character(
                Names.Anita.ToString(),
                Gender.Female,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Blue,
                FacialHair.None,
                null));
            Characters.Add(new Character(
                Names.Sophie.ToString(),
                Gender.Female,
                HairColour.Black,
                HairStyle.Stuff,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigMouth, OthersAttributes.BigNose, OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Charles.ToString(),
                Gender.Male,
                HairColour.None,
                HairStyle.Bald,
                EyesColour.Brown,
                FacialHair.Mustache,
                new[] { OthersAttributes.Glasses, OthersAttributes.BigNose }.ToList()));
            Characters.Add(new Character(
                Names.Stephen.ToString(),
                Gender.Male,
                HairColour.Ginger,
                HairStyle.Partition,
                EyesColour.Blue,
                FacialHair.Mustache,
                null));
            Characters.Add(new Character(
                Names.Eric.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Hat,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Isabelle.ToString(),
                Gender.Female,
                HairColour.Ginger,
                HairStyle.Curly,
                EyesColour.Brown,
                FacialHair.None,
                null));
            Characters.Add(new Character(
                Names.Victor.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Partition,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigMouth, OthersAttributes.BigNose }.ToList()));
        }
        

        public Character GetCharacterByName(string name)
        {
            foreach(var c in Characters)
            {
                if(c.Name == name.ToString())
                {
                    return c;
                }
            }
            return null;
        }


        internal List<Character> Discard(Question q, bool answer, bool perform = false)
        {
            List<Character> discards = new List<Character>();

            foreach (var c in Characters)
            {
                if (c.Discarded)
                    continue;

                switch (q)
                {
                    case Question.Man_Gender:

                        if (c.Gender == Gender.Male && !answer ||
                            c.Gender != Gender.Male && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        
                        break;
                    case Question.Woman_Gender:

                        if (c.Gender == Gender.Female && !answer ||
                            c.Gender != Gender.Female && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        
                        break;


                    case Question.Ginger_HairColour:

                        if (c.HairColour == HairColour.Ginger && !answer ||
                            c.HairColour != HairColour.Ginger && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.Black_HairColour:

                        if (c.HairColour == HairColour.Black && !answer ||
                            c.HairColour != HairColour.Black && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.WhiteHair_HairColour:

                        if (c.HairColour == HairColour.White && !answer ||
                            c.HairColour != HairColour.White && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.BrownHair_HairColour:

                        if (c.HairColour == HairColour.Brown && !answer ||
                            c.HairColour != HairColour.Brown && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.BlondHair_HairColour:

                        if (c.HairColour == HairColour.Blond && !answer ||
                            c.HairColour != HairColour.Blond && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;


                    case Question.PartitionHair_HairStyle:

                        if (c.HairStyle == HairStyle.Partition && !answer ||
                            c.HairStyle != HairStyle.Partition && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.CurlyHair_HairStyle:

                        if (c.HairStyle == HairStyle.Curly && !answer ||
                            c.HairStyle != HairStyle.Curly && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.HatHair_HairStyle:

                        if (c.HairStyle == HairStyle.Hat && !answer ||
                            c.HairStyle != HairStyle.Hat && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.Bald_HairStyle:

                        if (c.HairStyle == HairStyle.Bald && !answer ||
                            c.HairStyle != HairStyle.Bald && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.Stuff_HairStyle:

                        if (c.HairStyle == HairStyle.Stuff && !answer ||
                            c.HairStyle != HairStyle.Stuff && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.LongHair_HairStyle:

                        if (c.HairStyle == HairStyle.LongHair && !answer ||
                            c.HairStyle != HairStyle.LongHair && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                        

                    case Question.Brown_EyesColour:

                        if (c.EyesColour == EyesColour.Brown && !answer ||
                            c.EyesColour != EyesColour.Brown && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.Blue_EyesColour:

                        if (c.EyesColour == EyesColour.Blue && !answer ||
                            c.EyesColour != EyesColour.Blue && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;

                    case Question.Mustache_FacialHair:
                        if (c.FacialHair == FacialHair.Mustache && !answer ||
                            c.FacialHair != FacialHair.Mustache && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.Beard_FacialHair:
                        if (c.FacialHair == FacialHair.Beard && !answer ||
                            c.FacialHair != FacialHair.Beard && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.BillyGoat_FacialHair:
                        if (c.FacialHair == FacialHair.BillyGoat && !answer ||
                            c.FacialHair != FacialHair.BillyGoat && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;

                    case Question.Glasses_OtherAttribute:
                        if (c.HasOtherAttribute(OthersAttributes.Glasses) && !answer ||
                            !c.HasOtherAttribute(OthersAttributes.Glasses) && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.EarRings_OtherAttribute:
                        if (c.HasOtherAttribute(OthersAttributes.EarRings) && !answer ||
                            !c.HasOtherAttribute(OthersAttributes.EarRings) && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.BigMouth_OtherAttribute:
                        if (c.HasOtherAttribute(OthersAttributes.BigMouth) && !answer ||
                            !c.HasOtherAttribute(OthersAttributes.BigMouth) && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.BigNose_OtherAttribute:
                        if (c.HasOtherAttribute(OthersAttributes.BigNose) && !answer ||
                            !c.HasOtherAttribute(OthersAttributes.BigNose) && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;
                    case Question.RedCheeks_OtherAttribute:
                        if (c.HasOtherAttribute(OthersAttributes.RedCheeks) && !answer ||
                            !c.HasOtherAttribute(OthersAttributes.RedCheeks) && answer)
                        {
                            DiscardSingle(c, perform);
                            discards.Add(c);
                        }
                        break;


                    default:
                        return discards;

                }
            }
            return discards;
        }

        internal void DiscardSingle(Character c, bool perform = true)
        {
            if (perform)
            {
                if (Logger != null)
                    Logger.WriteToLog(c.Name+" has been discarded.");
                c.Off();
            }
        }

        public override string ToString()
        {
            string res = "";
            int lap = 0;
            int max = 8;

            res += "+---------------------------------------------------------------------------------------+" + Environment.NewLine;
            foreach(var c in Characters)
            {
                if (lap == 0)
                    res += "|";

                if (c.Discarded)
                    //res += String.Format(" -------- |");
                    res += String.Format("          |");
                else
                    res += String.Format(" {0} |", c.Name.PadLeft(8));

                lap++;

                if (lap == max)
                {
                    res += Environment.NewLine;
                    lap = 0;
                }
            }
            res += "+---------------------------------------------------------------------------------------+" + Environment.NewLine;
            
            return res;
        }
    }
}
