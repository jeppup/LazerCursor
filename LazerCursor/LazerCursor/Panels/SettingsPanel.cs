using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing;

namespace LazerCursor.Panels
{
    public partial class SettingsPanel : UserControl
    {
        public Settings SelectedSettings { get; set; }
        public SettingsPanel()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            //Default values
            SelectedSettings = new Settings()
            {
                LazerColor = RGBType.Green,
                MouseMovementScaling = 10,
                LazerIntensityThreshold = 240,
                ClickThreshold = 500,
                LerpSteps = 10
            };

            this.ColorMode_comboBox.SelectedIndex = 0;
            this.CursorScaling_TextBox.Text = SelectedSettings.MouseMovementScaling.ToString();
            this.Threshold_TextBox.Text = SelectedSettings.LazerIntensityThreshold.ToString();
            this.ClickThreshold_txtBox.Text = SelectedSettings.ClickThreshold.ToString();
            this.LerpSteps_txtBox.Text = SelectedSettings.LerpSteps.ToString();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedSettings.LazerColor = ResolveColorSettings();
                SelectedSettings.MouseMovementScaling = ResolveMovementScalingSettings();
                SelectedSettings.LazerIntensityThreshold = int.Parse(this.Threshold_TextBox.Text);
                SelectedSettings.ClickThreshold = long.Parse(this.ClickThreshold_txtBox.Text);
                SelectedSettings.LerpSteps = int.Parse(this.LerpSteps_txtBox.Text);
            }
            catch(Exception ex)
            {
                //..Formatting error
            }
        }

        private int ResolveThresholdSettings()
        {
            try
            {
                var thresholdSettings = int.Parse(this.Threshold_TextBox.Text);
                if(thresholdSettings > 254 || thresholdSettings < 1)
                {
                    throw new Exception("Threshold out of bounds");
                }

                return thresholdSettings;
            }
            catch(Exception ex)
            {
                return 240;
            }
        }

        private int ResolveMovementScalingSettings()
        {
            try
            {
                var scalingSettings = int.Parse(this.CursorScaling_TextBox.Text);
                if(scalingSettings == 0)
                    throw new Exception("Cant be 0");
                if(scalingSettings < 0)
                    throw new Exception("Must be positive");
                return scalingSettings;
            }
            catch(Exception e)
            {
                //default
                return 10;
            }
        }

        private RGBType ResolveColorSettings()
        {
            if(ColorMode_comboBox.SelectedIndex == 0)
            {
                return RGBType.Red;
            }
            if(ColorMode_comboBox.SelectedIndex == 1)
            {
                return RGBType.Green;
            }
            if(ColorMode_comboBox.SelectedIndex == 2)
            {
                return RGBType.Blue;
            }

            //Default
            return RGBType.Green;

        }
    }
}
