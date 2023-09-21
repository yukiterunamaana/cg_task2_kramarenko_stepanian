using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Task2_Kramarenko_Stepanian
{
    internal static class Program
    {

        //by Ilia
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
            image.Save("output1_1.jpg");

            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B);
                    Color newPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                    image.SetPixel(x, y, newPixel);
                }
            image.Save("output1_2.jpg");
        }
        //TODO histograms

        //By Arthur
        static void Task2()
        {
            Bitmap image = new Bitmap("image2.jpg");
            Bitmap redImage = new Bitmap(image.Width, image.Height);
            Bitmap greenImage = new Bitmap(image.Width, image.Height);
            Bitmap blueImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color redColor = Color.FromArgb(pixelColor.R, 0, 0);
                    Color greenColor = Color.FromArgb(0, pixelColor.G, 0);
                    Color blueColor = Color.FromArgb(0, 0, pixelColor.B);
                    redImage.SetPixel(x, y, redColor);
                    greenImage.SetPixel(x, y, greenColor);
                    blueImage.SetPixel(x, y, blueColor);
                }
            }
            redImage.Save("image2Red.jpg");
            greenImage.Save("image2Green.jpg");
            blueImage.Save("image2Blue.jpg");
        }
        //TODO histogram

        //TODO Task3, alteration functions

        /*
        static Bitmap AlterHue(Bitmap hsvImage, float hueOffset)
        {
            Bitmap alteredImage = new Bitmap(hsvImage.Width, hsvImage.Height);

            for (int y = 0; y < hsvImage.Height; y++)
            {
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    Color hsvPixel = hsvImage.GetPixel(x, y);
                    float h = hsvPixel.GetHue() / 255.0f * 360;
                    float s = hsvPixel.GetSaturation();
                    float v = hsvPixel.GetBrightness();

                    h += hueOffset;
                    if (h > 360)
                    {
                        h -= 360;
                    }
                    else if (h < 0)
                    {
                        h += 360;
                    }

                    Color alteredPixel = Color.FromArgb((int)(h / 360 * 255), (int)(s * 255), (int)(v * 255));
                    alteredImage.SetPixel(x, y, alteredPixel);
                }
            }

            return alteredImage;
        }

        static Bitmap AlterSaturation(Bitmap hsvImage, float saturationScale)
        {
            Bitmap alteredImage = new Bitmap(hsvImage.Width, hsvImage.Height);

            for (int y = 0; y < hsvImage.Height; y++)
            {
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    Color hsvPixel = hsvImage.GetPixel(x, y);
                    float h = hsvPixel.GetHue() / 255.0f * 360;
                    float s = hsvPixel.GetSaturation();
                    float v = hsvPixel.GetBrightness();

                    s *= saturationScale;
                    if (s > 1)
                    {
                        s = 1;
                    }
                    else if (s < 0)
                    {
                        s = 0;
                    }

                    Color alteredPixel = Color.FromArgb((int)(h / 360 * 255), (int)(s * 255), (int)(v * 255));
                    alteredImage.SetPixel(x, y, alteredPixel);
                }
            }

            return alteredImage;
        }

        static Bitmap AlterLightness(Bitmap hsvImage, float lightnessScale)
        {
            Bitmap alteredImage = new Bitmap(hsvImage.Width, hsvImage.Height);

            for (int y = 0; y < hsvImage.Height; y++)
            {
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    Color hsvPixel = hsvImage.GetPixel(x, y);
                    float h = hsvPixel.GetHue() / 255.0f * 360;
                    float s = hsvPixel.GetSaturation();
                    float v = hsvPixel.GetBrightness();

                    v *= lightnessScale;
                    if (v > 1)
                    {
                        v = 1;
                    }
                    else if (v < 0)
                    {
                        v = 0;
                    }

                    Color alteredPixel = Color.FromArgb((int)(h / 360 * 255), (int)(s * 255), (int)(v * 255));
                    alteredImage.SetPixel(x, y, alteredPixel);
                }
            }

            return alteredImage;
        }

        static void Task3()
        {

        }
        */
        static void Main()
        {
            Task1();
            Task2();
        }
    }
}
