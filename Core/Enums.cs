using System;
using System.ComponentModel;
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
        Anne,
        Roger,
        Paul,
        Frank,
        Max,
        Philippe,
        Katrin,
        Daniel,
        Bernard,
        Hans,
        Herman,
        Joe,
        Theo,
        Sarah,
        Marta,
        Lucas,
        Carmen,
        Anita,
        Sophie,
        Charles,
        Eric,
        Victor
    }

    public enum Gender
    {
        Male,
        Female,
    }

    public enum HairColour
    {
        Ginger,
        Black,
        White,
        Brown,
        Blond,
    }

    public enum HairStyle
    {
        Hat,
        Bald,
        Curly,
        Partition
    }

    public enum EyesColour
    {
        Brown,
        Blue
    }
    
    public enum SkinColour
    {
        Black,
        White
    }
    
    public enum OthersAttributes
    {
        Mustache,
        Beard,
        Glasses,
        BigMouth,
        BigNose,
        EarRings,
    }

    // http://chalkdustmagazine.com/blog/cracking-guess-board-game/
    public enum Question
    {
        [Description("No question")]
        None,

        // Gender
        [Description("Is it a man?")]
        Man_Gender,
        [Description("Is it a woman?")]
        Woman_Gender,
        
        // Hair Colour
        [Description("Does it have ginger hair?")]
        Ginger_HairColour,
        [Description("Does it have black hair?")]
        Black_HairColour,
        [Description("Does it have white hair?")]
        WhiteHair_HairColour,
        [Description("Does it have brown hair?")]
        BrownHair_HairColour,
        [Description("Does it have blond hair?")]
        BlondHair_HairColour,
        
        // Hair Style
        [Description("Does it wear a hat?")]
        HatHair_HairStyle,
        [Description("Does it have a bald head?")]
        Bald_HairStyle,
        [Description("Does it have curly hair?")]
        CurlyHair_HairStyle,
        [Description("Does it have partition hair?")]
        PartitionHair_HairStyle,

        // Eyes colour
        [Description("Does it have brown eyes?")]
        Brown_EyesColour,
        [Description("Does it habe blue eyes?")]
        Blue_EyesColour,

        // Skin colour
        [Description("Is its skin black colour?")]
        Black_SkinColour,
        [Description("Is its skin white colour?")]
        White_SkinColour,
        
        // Other Attributes
        [Description("Does it has a mustache?")]
        Mustache_OtherAttribute,
        [Description("Does it has a beard?")]
        Beard_OtherAttribute,
        [Description("Does it wear glasses?")]
        Glasses_OtherAttribute,
        [Description("Does it have big mouth?")]
        BigMouth_OtherAttribute,
        [Description("Does it have big nose?")]
        BigNose_OtherAttribute,
        [Description("Does it wear ear rings?")]
        EarRings_OtherAttribute,
    }


    public enum AICategory
    {
        Human = 0,
        Random
    }
}
