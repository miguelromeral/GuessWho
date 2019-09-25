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
        Maria,
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
        // Gender
        [Description("Is it a man?")]
        Man,
        [Description("Is it a woman?")]
        Woman,

        // Hair Colour
        [Description("TBD")]
        Ginger_HairColour,
        [Description("TBD")]
        Black_HairColour,
        [Description("TBD")]
        WhiteHair_HairColour,
        [Description("TBD")]
        BrownHair_HairColour,
        [Description("TBD")]
        BlondHair_HairColour,

        // Hair Style
        [Description("TBD")]
        PartitionHair_HairStyle,
        [Description("TBD")]
        CurlyHair_HairStyle,
        [Description("TBD")]
        HatHair_HairStyle,
        [Description("TBD")]
        Bald_HairStyle,
        [Description("TBD")]
        Stuff_HairStyle,
        [Description("TBD")]
        LongHair_HairStyle,

        // Eyes colour
        [Description("TBD")]
        Brown_EyesColour,
        [Description("TBD")]
        Blue_EyesColour,
        
        // Facial hair
        [Description("TBD")]
        None_FacialHair,
        [Description("TBD")]
        Mustache_FacialHair,
        [Description("TBD")]
        Beard_FacialHair,
        [Description("TBD")]
        BillyGoat_FacialHair,

        // Other Attributes
        [Description("TBD")]
        Glasses_OtherAttribute,
        [Description("TBD")]
        EarRings_OtherAttribute,
        [Description("TBD")]
        BigMouth_OtherAttribute,
        [Description("TBD")]
        BigNose_OtherAttribute,
        [Description("TBD")]
        RedCheeks_OtherAttribute,
    }


    public enum AICategory
    {
        Human = 0,
        Random
    }
}
