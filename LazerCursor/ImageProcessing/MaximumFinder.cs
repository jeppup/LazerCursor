using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    class MaximumFinder
    {
        public Pixel FindMax(System.Drawing.Imaging.BitmapData bmpData, RGBType color, int threshold)
        {
            IntPtr startPtr = bmpData.Scan0;
            int numberOfBytes = Math.Abs(bmpData.Stride) * bmpData.Height;
            byte[] rgbValues = new byte[numberOfBytes];
            System.Runtime.InteropServices.Marshal.Copy(startPtr, rgbValues, 0, numberOfBytes);
            var maxValue = 0;
            var maxIndex = 0;
            //RGBValues is order [A,R,G,B,A,R,G,B..], we iterate over green pixels cuz green color bitch
            for (int i = 2; i < rgbValues.Length; i = i + 4)
            {
                if (rgbValues[i] > maxValue)
                {
                    maxValue = rgbValues[i];
                    maxIndex = i;
                }
            }

            //Actual pixel indecies
            var pixelIndex = maxIndex / 4;
            var xIndex = (pixelIndex % bmpData.Width);
            var yIndex = (pixelIndex / bmpData.Height);

            
            var xIterator = maxIndex - (4*xIndex);
            var yIterator = 4 * xIndex;
            var xIteratorBound = xIterator;

            //Draw horizontal line
            while (xIterator < xIteratorBound + 4 * bmpData.Width)
            {
                rgbValues[xIterator] = 250;
                xIterator = xIterator + 4;
            }

            //Draw vertical line
            while (yIterator < rgbValues.Length)
            {
                rgbValues[yIterator+2] = 250;
                yIterator = yIterator + 4 * bmpData.Width;
            }
           
            //Store modified bits in original memory location
            System.Runtime.InteropServices.Marshal.Copy(rgbValues,0, startPtr, numberOfBytes);
            var result = new Pixel()
            {
                Intensity = maxValue,
                X = xIndex,
                Y = yIndex
            };

            return result;
        }

        private int GetColorValue(Color pixel, RGBType colorType)
        {
            if (colorType == RGBType.Green)
            {
                return pixel.G;
            }

            else return 0;
        }
    }

    public enum RGBType{ Red, Green, Blue};

    public struct Area{
        public int XStart;
        public int XLength;
        public int YStart;
        public int YLength;
    }
}
