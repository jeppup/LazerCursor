using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    public class Pixel : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int Intensity{ get; set; }
        
        public int CompareTo(object obj)
        {
            var compareObject = (Pixel)obj;
            if(Intensity > compareObject.Intensity)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
