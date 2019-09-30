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
            string file = "";

            switch (name)
            {
                case "Isabelle":
                    path += "isabelle.png";
                    break;
                case "Max":
                    path += "max.png";
                    break;
                case "Victor":
                    path += "victor.png";
                    break;
                default:
                    path += "unknown.png";
                    break;
            }
            return path;


            //try
            //{
            //    foreach (var n in Enum.GetNames(typeof(Names)))
            //    {
            //        if (n.ToString() == name)
            //        {



            //            file = name.ToLower() + ".png";

            //            if (Directory.Exists(path + file))
            //            {
            //                file = path + file;
            //                return path;
            //            }
            //            else
            //            {
            //                throw new Exception("No image found");
            //            }
            //        }
            //    }
            //    return path + "unknown.png";
            //}
            //catch (Exception)
            //{
            //    return path + "unknown.png";
            //}
        }
    }
}
