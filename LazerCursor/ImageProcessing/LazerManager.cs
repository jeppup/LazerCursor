using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    public class LazerManager
    {
        private MaximumFinder MaxFinder;
        private Pixel PreviousPixel { get; set; }
        private Pixel CurrentPixel { get; set; }
        public Settings SelectedSettings { get; set; }

        public LazerManager(Settings settings)
        {
            MaxFinder = new MaximumFinder();
            SelectedSettings = settings;
        }

        public CursorChange CalculateChangeLockedBits(Bitmap image)
        {
            List<Pixel> pixelList = new List<Pixel>();

            Rectangle subImage = new Rectangle()
            {
                Height = image.Height,
                Width = image.Width,
                X = 0,
                Y = 0
            };

            var bmpData = image.LockBits(subImage, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var maxIntensityPixel = MaxFinder.FindMax(bmpData, SelectedSettings.LazerColor, SelectedSettings.LazerIntensityThreshold);
            image.UnlockBits(bmpData);
            
            //Set the previously captured pixel
            if (CurrentPixel != null)
            {
                PreviousPixel = CurrentPixel;
            }

            
            if (maxIntensityPixel.Intensity > SelectedSettings.LazerIntensityThreshold)
            {
                CurrentPixel = maxIntensityPixel;
                if (PreviousPixel != null)
                    return new CursorChange(CurrentPixel, PreviousPixel);
            }
            //If nothing was caught, reset state
            else
            {
                PreviousPixel = null;
                CurrentPixel = null;
            }

            return null;
        }
    }
}
