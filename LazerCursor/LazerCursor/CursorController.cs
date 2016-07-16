using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessing;
using System.Threading;

namespace LazerCursor
{
    public class CursorController
    {
        
        public Settings SelectedSettings { get; set; }
        private ClickController ClickController { get; set; }
        private Task CursorMover { get; set; }
        Pixel TargetPoint { get; set; }
        Pixel DeltaVector { get; set; }
        public int FrameRateMilliseconds;

        public CursorController(Settings settings)
        {
            SelectedSettings = settings;
            ClickController = new ClickController(settings);
        }

        public void AddMovement(CursorChange change, int msLerpInterval, Rectangle screenResolution, Rectangle cameraResolution)
        {
            if (CursorMover != null && !CursorMover.IsCompleted)
            {
                //Maybe just cancel here instead, like an interupt.. Better performance but less accuracy
                CursorMover.Wait();
            }

            double widthMultiplier = screenResolution.Width / cameraResolution.Width;
            double heightMultiplier = screenResolution.Height / cameraResolution.Height;

            TargetPoint = new Pixel() { 
                X = (int)Math.Ceiling(Cursor.Position.X + (change.DeltaX * widthMultiplier)),
                Y = (int)Math.Ceiling(Cursor.Position.Y + (change.DeltaY * heightMultiplier)) 
            };
            FrameRateMilliseconds = msLerpInterval;
            StartMovement();
        }

        private void StartMovement() {
            CursorMover = Task.Factory.StartNew(async () =>
            {
                DeltaVector = new Pixel();
                DeltaVector.X = (TargetPoint.X - Cursor.Position.X) / SelectedSettings.LerpSteps;
                DeltaVector.Y = (TargetPoint.Y - Cursor.Position.Y) / SelectedSettings.LerpSteps;
                for (int i = 0; i < SelectedSettings.LerpSteps; i++)
                {
                    Cursor.Position = new Point(Cursor.Position.X + DeltaVector.X, Cursor.Position.Y + DeltaVector.Y);
                    await Task.Delay(FrameRateMilliseconds / SelectedSettings.LerpSteps);
                }
            });
        }

        public void ClickEvent(bool registerdLazer)
        {
            if (registerdLazer)
                ClickController.NewCapture();
            else
                ClickController.NewNoneCapture();
        }

    }
}
