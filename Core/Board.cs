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
                Names.Maria.ToString(),
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
                HairStyle.LongHair,
                EyesColour.Brown,
                FacialHair.None,
                null));
            Characters.Add(new Character(
                Names.Victor.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Bald,
                EyesColour.Brown,
                FacialHair.None,
                new[] { OthersAttributes.BigMouth }.ToList()));
        }
        

        internal int Discard(Question q, bool answer, bool perform = false)
        {
            int discards = 0;

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
                            discards++;
                        }
                        
                        break;
                    case Question.Woman_Gender:

                        if (c.Gender == Gender.Female && !answer ||
                            c.Gender != Gender.Female && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        
                        break;
                    case Question.Ginger_HairColour:

                        if (c.HairColour == HairColour.Ginger && !answer ||
                            c.HairColour != HairColour.Ginger && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;

                    case Question.Black_HairColour:

                        if (c.HairColour == HairColour.Black && !answer ||
                            c.HairColour != HairColour.Black && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;

                    case Question.WhiteHair_HairColour:

                        if (c.HairColour == HairColour.White && !answer ||
                            c.HairColour != HairColour.White && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;

                    case Question.BrownHair_HairColour:

                        if (c.HairColour == HairColour.Brown && !answer ||
                            c.HairColour != HairColour.Brown && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;

                    case Question.BlondHair_HairColour:

                        if (c.HairColour == HairColour.Blond && !answer ||
                            c.HairColour != HairColour.Blond && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;



                    case Question.Brown_EyesColour:

                        if (c.EyesColour == EyesColour.Brown && !answer ||
                            c.EyesColour != EyesColour.Brown && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;
                    case Question.Blue_EyesColour:

                        if (c.EyesColour == EyesColour.Blue && !answer ||
                            c.EyesColour != EyesColour.Blue && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                        break;


                    default:
                        return -1;

                }
            }
            return discards;
        }

        private void DiscardSingle(Character c, bool perform)
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
