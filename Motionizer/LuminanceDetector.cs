using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motionizer.Effects
{
    class LuminanceDetector : IMotionizerEffect
    {

        private SolidBrush black;
        private SolidBrush white;
        private int lum_threshold;
        private int lum_area;

        public LuminanceDetector(int lum_threshold, int lum_area = 10)
        {
            this.lum_threshold = lum_threshold;
            this.lum_area = lum_area;
            black = new SolidBrush(Color.FromArgb(0, 0, 0));
            white = new SolidBrush(Color.FromArgb(255, 255, 255));
        }

        public int Threshold
        {
            get
            {
                return this.lum_threshold;
            }
            set
            {
                this.lum_threshold = value;
            }
        }

        public int LuminanceArea
        {
            get
            {
                return this.lum_area;
            }
            set
            {
                this.lum_area = value;
            }
        }

        public Bitmap processFrame(params Bitmap[] frame)
        {
            Bitmap luminanceFrame = new Bitmap(frame[0].Width, frame[0].Height);
            // Filling the luminance frame with black color
            Graphics gfx = Graphics.FromImage(luminanceFrame);
            gfx.FillRectangle(black, 0, 0, frame[0].Width, frame[0].Height);

            for (int y = 0; y < frame[0].Height; y += 10 )
            {
                bool foundLuminatedArea = false; // indicates whether the luminated area is found or not

                for (int x = 0; x < frame[0].Width; x += 10)
                {
                    byte red, green, blue;
                    red = frame[0].GetPixel(x, y).R;
                    green = frame[0].GetPixel(x, y).G;
                    blue = frame[0].GetPixel(x, y).B;
                    // luminance of the pixel
                    float brightness = (299 * red + 587 * green + 114 * blue) / 1000f;

                    if (brightness > this.lum_threshold)
                    {
                        // Checking Luminance area only vertically
                        int area = 1;
                        // Since we hit the horizontal and the uppermost pixel in x
                        for (int i = 0; i < this.lum_area; i++)
                        {
                            int ty = (y + i) >= frame[0].Height ? frame[0].Height-1 : y + i;
                            red = frame[0].GetPixel(x, ty).R;
                            green = frame[0].GetPixel(x, ty).G;
                            blue = frame[0].GetPixel(x, ty).B;
                            brightness = (299 * red + 587 * green + 114 * blue) / 1000;
                            if (brightness > this.lum_threshold)
                            {
                                area++;
                            }
                        }
                        // Checking if we got the area
                        if (area >= this.lum_area)
                        {
                            int ix = (x - 5) < 0 ? 0 : x - 5;
                            int iy = (y - 5) < 0 ? 0 : y - 5;
                            gfx.FillEllipse(white, ix, iy, 10, 10);
                            foundLuminatedArea = true;
                            break;
                        }
                    } // (brightness > this.lum_threshold)
                } // x loop

                if (foundLuminatedArea == true) break;
            } // y loop

            return luminanceFrame;
        }

    }
}
