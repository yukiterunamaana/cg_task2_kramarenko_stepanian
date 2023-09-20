using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CG_Task2_Kramarenko_Stepanian
{
    internal static class Program
    {
        static void Task1() 
        {
            Bitmap image = new Bitmap("input1.jpg");
            for (int x = 0; x < image.Width; x++)
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                Color newPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                image.SetPixel(x, y, newPixel);
            }
            image.Save("output1.jpg");
        }

        static void Main()
        {
            Task1();
        }
    }
}
