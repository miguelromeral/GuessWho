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
        None,
        Ginger,
        Black,
        White,
        Brown,
        Blond,
    }

    public enum HairStyle
    {
        Partition, // Hacia los lados, raya en medio
        Curly,
        Hat,
        Bald, // Muy corto, rapado, sin pelo, calo
        Stuff,
        LongHair
    }

    public enum EyesColour
    {
        Brown,
        Blue
    }
    
    public enum FacialHair
    {
        None,
        Mustache,
        Beard,
        BillyGoat,  // Perillas
    }

    public enum OthersAttributes
    {
        Glasses,
        EarRings,
        BigMouth,
        BigNose,
        RedCheeks, // mejillas coloradas
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
        [Description("Does it have partition hair?")]
        PartitionHair_HairStyle,
        [Description("Does it have curly hair?")]
        CurlyHair_HairStyle,
        [Description("Does it wear a hat?")]
        HatHair_HairStyle,
        [Description("Does it have a bald head?")]
        Bald_HairStyle,
        [Description("Does it have stuff in its hair?")]
        Stuff_HairStyle,
        [Description("Does it have long hair?")]
        LongHair_HairStyle,
        
        // Eyes colour
        [Description("Does it have brown eyes?")]
        Brown_EyesColour,
        [Description("Does it habe blue eyes?")]
        Blue_EyesColour,
        
        // Facial hair
        [Description("Does it have shaved face?")]
        None_FacialHair,
        [Description("Does it have mustache?")]
        Mustache_FacialHair,
        [Description("Does it have beard?")]
        Beard_FacialHair,
        [Description("Does it have billy goat?")]
        BillyGoat_FacialHair,
        
        // Other Attributes
        [Description("Does it wear glasses?")]
        Glasses_OtherAttribute,
        [Description("Does it wear ear rings?")]
        EarRings_OtherAttribute,
        [Description("Does it have big mouth?")]
        BigMouth_OtherAttribute,
        [Description("Does it have big nose?")]
        BigNose_OtherAttribute,
        [Description("Does it have red cheeks?")]
        RedCheeks_OtherAttribute,
    }


    public enum AICategory
    {
        Human = 0,
        Random
    }
}
