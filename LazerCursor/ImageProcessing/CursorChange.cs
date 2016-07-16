using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class CursorChange
    {
        public int Distance;
        public int Angle;
        public int DeltaX;
        public int DeltaY;
        public CursorChange(Pixel pixelOne, Pixel pixelTwo)
        { 
            Distance = (int)Math.Sqrt(
                Math.Pow((double)(pixelOne.X - pixelTwo.X), 2) + 
                Math.Pow((double)(pixelOne.Y - pixelTwo.Y), 2)
            );

            DeltaX = pixelOne.X - pixelTwo.X;
            DeltaY = pixelOne.Y - pixelTwo.Y;
        }

        public long CalculationTime;
    }
}
