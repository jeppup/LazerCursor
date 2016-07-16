using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using ImageProcessing;
using System.Diagnostics;

namespace LazerCursor
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private LazerManager lazerManager;
        private ImageProcessingHandler ImageProcessor;
        private CursorController cursorController;
        private Settings SelectedSettings;
        private Stopwatch FrameRateTimer;
        private long AverageFrameRate = 0;

        public Form1()
        {
            InitializeComponent();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                inputDropDown.Items.Add(device.Name);
            }

            Settings_Panel.Initialize();
            SelectedSettings = Settings_Panel.SelectedSettings;
            lazerManager = new LazerManager(SelectedSettings);
            cursorController = new CursorController(SelectedSettings);
            FrameRateTimer = new Stopwatch();

            inputDropDown.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[inputDropDown.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += FinalFrame_NewFrame;
            FinalFrame.Start();
            //ResolutionLabel.Text = FinalFrame.VideoCapabilities.First().FrameSize.Height + " x " + FinalFrame.VideoCapabilities.First().FrameSize.Width;
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var imageClone = (Bitmap)(eventArgs.Frame.Clone());
            var cursorChange = lazerManager.CalculateChangeLockedBits(imageClone);

            if (FrameRateTimer.IsRunning)
            {
                FrameRateTimer.Stop();
                var timeElapsed = ((double)FrameRateTimer.Elapsed.Milliseconds / 1000);
                this.BeginInvoke((Action)(() =>
                {
                    Fps_Label.Text = Math.Round(1/timeElapsed) + " fps, avg: " + AverageFrameRate;
                }));
                AverageFrameRate = (AverageFrameRate + FrameRateTimer.ElapsedMilliseconds) / 2;
            }
            displayBox.Image = imageClone;
            

            if (cursorChange != null)
            {
                if (ControlCursor_chkBox.Checked)
                {
                    cursorController.ClickEvent(true);
                    var screenRes = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                    var cameraRes = new Rectangle(0, 0, imageClone.Width, imageClone.Height);
                    cursorController.AddMovement(cursorChange, System.Convert.ToInt32(FrameRateTimer.ElapsedMilliseconds), screenRes, cameraRes);
                    //cursorController.AddMovement(cursorChange.DeltaX, cursorChange.DeltaY, AverageFrameRate/2);
                }

                this.BeginInvoke((Action)(() =>
                {
                    XValue.Text = cursorChange.DeltaX.ToString();
                    YValue.Text = cursorChange.DeltaY.ToString();
                }));
            }
            else
            {
                cursorController.ClickEvent(false);
            }
            FrameRateTimer.Reset();
            FrameRateTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
        }
    }
}
