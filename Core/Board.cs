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
                SkinColour.White,
                new[] {
                    OthersAttributes.EarRings,
                    OthersAttributes.Glasses
                }.ToList()));
            Characters.Add(new Character(
                Names.Roger.ToString(),
                Gender.Male,
                HairColour.Brown,
                HairStyle.Bald,
                EyesColour.Brown,
                SkinColour.Black,
                new[] {
                    OthersAttributes.Mustache,
                    OthersAttributes.Beard
                }.ToList()));
            Characters.Add(new Character(
                Names.Paul.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Partition,
                EyesColour.Brown,
                SkinColour.White,
                new[]
                {
                    OthersAttributes.Beard,
                    OthersAttributes.Glasses
                }.ToList()));
            Characters.Add(new Character(
                Names.Frank.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Hat,
                EyesColour.Brown,
                SkinColour.White,
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
                SkinColour.Black,
                new[] {
                    OthersAttributes.Beard,
                    OthersAttributes.BigMouth
                }.ToList()));
            Characters.Add(new Character(
                Names.Philippe.ToString(),
                Gender.Male,
                HairColour.Ginger,
                HairStyle.Bald,
                EyesColour.Brown,
                SkinColour.White,
                new[] {
                    OthersAttributes.Beard
                }.ToList()));
            Characters.Add(new Character(
                Names.Katrin.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Partition,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.EarRings }.ToList()));
            Characters.Add(new Character(
                Names.Daniel.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Bald,
                EyesColour.Blue,
                SkinColour.White,
                new[] { OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Bernard.ToString(),
                Gender.Male,
                HairColour.Brown,
                HairStyle.Hat,
                EyesColour.Brown,
                SkinColour.Black,
                new[] { OthersAttributes.BigNose }.ToList()));
            Characters.Add(new Character(
                Names.Hans.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Brown,
                SkinColour.White,
                new[] {
                    OthersAttributes.BigMouth,
                    OthersAttributes.Mustache
                }.ToList()));
            Characters.Add(new Character(
                Names.Herman.ToString(),
                Gender.Male,
                HairColour.Ginger,
                HairStyle.Bald,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.BigNose }.ToList()));
            Characters.Add(new Character(
                Names.Joe.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Blue,
                SkinColour.White,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Theo.ToString(),
                Gender.Male,
                HairColour.Black,
                HairStyle.Curly,
                EyesColour.Brown,
                SkinColour.White,
                new[] {
                    OthersAttributes.BigMouth,
                    OthersAttributes.Mustache,
                    OthersAttributes.BigNose
                }.ToList()));
            Characters.Add(new Character(
                Names.Sarah.ToString(),
                Gender.Female,
                HairColour.Blond,
                HairStyle.Hat,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.EarRings, OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Marta.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Hat,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.EarRings }.ToList()));
            Characters.Add(new Character(
                Names.Lucas.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Curly,
                EyesColour.Brown,
                SkinColour.White,
                 new[] { OthersAttributes.Mustache, OthersAttributes.Beard }.ToList()));
            Characters.Add(new Character(
                Names.Carmen.ToString(),
                Gender.Female,
                HairColour.Brown,
                HairStyle.Partition,
                EyesColour.Brown,
                SkinColour.Black,
                null));
            Characters.Add(new Character(
                Names.Anita.ToString(),
                Gender.Female,
                HairColour.Blond,
                HairStyle.Partition,
                EyesColour.Blue,
                SkinColour.White,
                null));
            Characters.Add(new Character(
                Names.Sophie.ToString(),
                Gender.Female,
                HairColour.Black,
                HairStyle.Curly,
                EyesColour.Brown,
                SkinColour.Black,
                new[] { OthersAttributes.BigMouth, OthersAttributes.BigNose, OthersAttributes.Glasses }.ToList()));
            Characters.Add(new Character(
                Names.Charles.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Bald,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.Glasses, OthersAttributes.BigNose, OthersAttributes.Mustache }.ToList()));
            Characters.Add(new Character(
                Names.Stephen.ToString(),
                Gender.Male,
                HairColour.Ginger,
                HairStyle.Partition,
                EyesColour.Blue,
                SkinColour.White, 
                new[] { OthersAttributes.Mustache }.ToList()));
            Characters.Add(new Character(
                Names.Eric.ToString(),
                Gender.Male,
                HairColour.Blond,
                HairStyle.Hat,
                EyesColour.Brown,
                SkinColour.White,
                new[] { OthersAttributes.BigMouth }.ToList()));
            Characters.Add(new Character(
                Names.Isabelle.ToString(),
                Gender.Female,
                HairColour.Ginger,
                HairStyle.Curly,
                EyesColour.Brown,
                SkinColour.White,
                null));
            Characters.Add(new Character(
                Names.Victor.ToString(),
                Gender.Male,
                HairColour.White,
                HairStyle.Partition,
                EyesColour.Brown,
                SkinColour.White,
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


        internal bool Discard(List<Character> discards)
        {
            bool success = false;

            foreach (var c in discards)
            {
                DiscardSingle(c);
                success = true;
            }
            
            return success;
        }


        internal List<Character> Discard(Question q, bool answer, bool perform = false)
        {
            List<Character> discards = new List<Character>();

            foreach (var c in Characters)
            {
                if (c.Discarded)
                    continue;

                bool? match = null;

                match = c.AnswerQuestion(q);

                if(match != null)
                {
                    if ((bool) match ^ answer)
                    {
                        DiscardSingle(c, perform);
                        discards.Add(c);
                    }
                }
                else
                {
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
