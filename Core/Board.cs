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
                Names.Stephen.ToString(),
                Gender.Male,
                HairColour.Ginger,
                HairStyle.Partition, //??????
                //new[] { FacialAttributes. }.ToList();
                EyesColour.Blue,
                FacialHair.Mustache,
                null));

            
        }
        

        internal int Discard(Question q, bool answer, bool perform = false)
        {
            int discards = 0;
            switch (q)
            {
                case Question.Man:
                    foreach (var c in Characters)
                    {
                        if (c.Discarded)
                            continue;
                        
                        if (c.Gender == Gender.Male && !answer ||
                            c.Gender != Gender.Male && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                    }
                    break;
                case Question.Woman:
                    foreach(var c in Characters)
                    {
                        if (c.Discarded)
                            continue;

                        if (c.Gender == Gender.Female && !answer ||
                            c.Gender != Gender.Female && answer)
                        {
                            DiscardSingle(c, perform);
                            discards++;
                        }
                    }
                    break;
                default:
                    return -1;
            }
            return discards;
        }

        private void DiscardSingle(Character c, bool perform)
        {
            if (perform)
                c.Off();
        }
    }
}
