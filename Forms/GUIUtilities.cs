using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Forms
{
    static class GUIUtilities
    {
        

        


        public static Image SetImageOpacity(Image image, double per, float opacity)
        {
            Bitmap bmp = new Bitmap((int)(per * image.Width), (int)(per * image.Height));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public static Image GetImageFromName(string name) {
            return new Bitmap(GetImageFromNameString(name));
        }

        private static string GetImageFromNameString(string name)
        {
            string path = Directory.GetCurrentDirectory() + "/Images/";

            return path += "max.bmp";

            //switch (c.Color)
            //{
            //    case Card.CardColor.Bionic:
            //        path += "bionic";
            //        break;
            //    case Card.CardColor.Blue:
            //        path += "blue";
            //        break;
            //    case Card.CardColor.Green:
            //        path += "green";
            //        break;
            //    case Card.CardColor.Red:
            //        path += "red";
            //        break;
            //    case Card.CardColor.Yellow:
            //        path += "yellow";
            //        break;
            //    case Card.CardColor.Wildcard:
            //        path += "wild";
            //        break;
            //    case Card.CardColor.Purple:
            //        switch (c.Face)
            //        {
            //            case Card.CardFace.LatexGlove:
            //                path += "latexglove.bmp";
            //                break;
            //            case Card.CardFace.MedicalError:
            //                path += "medicalerror.bmp";
            //                break;
            //            case Card.CardFace.OrganThief:
            //                path += "organthief.bmp";
            //                break;
            //            case Card.CardFace.Overtime:
            //                path += "overtime.bmp";
            //                break;
            //            case Card.CardFace.ProtectiveSuit:
            //                path += "protectivesuit.bmp";
            //                break;
            //            case Card.CardFace.Quarantine:
            //                path += "quarantine.bmp";
            //                break;
            //            case Card.CardFace.SecondOpinion:
            //                path += "secondopinion.bmp";
            //                break;
            //            case Card.CardFace.Spreading:
            //                path += "spreading.bmp";
            //                break;
            //            case Card.CardFace.Transplant:
            //                path += "transplant.bmp";
            //                break;
            //            default:
            //                path += "none.bmp";
            //                break;
            //        }
            //        return path;
            //    default:
            //        path += "none.bmp";
            //        return path;
            //}

            //switch (c.Face)
            //{
            //    case Card.CardFace.Organ:
            //        path += "_organ.bmp";
            //        break;
            //    case Card.CardFace.Virus:
            //        path += "_virus.bmp";
            //        break;
            //    case Card.CardFace.Medicine:
            //        path += "_medicine.bmp";
            //        break;
            //    case Card.CardFace.EvolvedMedicine:
            //        path += "_experimental.bmp";
            //        break;
            //    case Card.CardFace.EvolvedVirus:
            //        path += "_evolvedvirus.bmp";
            //        break;
            //    default:
            //        path += "none.bmp";
            //        return path;
            //}
            //return path;
        }
    }
}
