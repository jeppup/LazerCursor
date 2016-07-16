using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using ImageProcessing;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace LazerCursor
{
    public class ClickController
    {
        private bool LazerCaptured = false;
        private Stopwatch captureIntervalTimer = new Stopwatch();
        private Settings Settings { get; set; }

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public ClickController(Settings selectedSettings)
        {
            Settings = selectedSettings;
        }

        //When a lazerInput was captured
        public void NewCapture()
        {
            if(LazerCaptured == false)
            {
                LazerCaptured = true;
                captureIntervalTimer.Start();
            }
        }

        //When a lazerinput was not captured
        public void NewNoneCapture()
        {
            if(LazerCaptured == true)
            {
                //Click registerd, must implement click-cooldown somehow here
                if (captureIntervalTimer.ElapsedMilliseconds < Settings.ClickThreshold)
                {
                    Debug.WriteLine("Click Captured");
                    int X = Cursor.Position.X;
                    int Y = Cursor.Position.Y;
                    mouse_event((uint)(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP), (uint)X, (uint)Y, 0, 0);
                    
                }

                LazerCaptured = false;
                captureIntervalTimer.Reset();
            }
        }
    }
}
