using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace ImageProcessing
{
    public class Settings
    {
        public int MouseMovementScaling { get; set; }
        public int LazerIntensityThreshold { get; set; }
        public int LerpSteps { get; set; }

        public RGBType LazerColor{ get; set; }
        public long ClickThreshold { get; set; }
    }
}
