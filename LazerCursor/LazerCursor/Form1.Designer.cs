namespace LazerCursor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.inputDropDown = new System.Windows.Forms.ComboBox();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fps_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlCursor_chkBox = new System.Windows.Forms.CheckBox();
            this.Settings_Panel = new LazerCursor.Panels.SettingsPanel();
            this.ParallellMode_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(29, 30);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(344, 261);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayBox.TabIndex = 0;
            this.displayBox.TabStop = false;
            // 
            // inputDropDown
            // 
            this.inputDropDown.FormattingEnabled = true;
            this.inputDropDown.Location = new System.Drawing.Point(64, 332);
            this.inputDropDown.Name = "inputDropDown";
            this.inputDropDown.Size = new System.Drawing.Size(121, 21);
            this.inputDropDown.TabIndex = 1;
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(64, 371);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(121, 23);
            this.CaptureButton.TabIndex = 2;
            this.CaptureButton.Text = "Capture";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fps_Label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ResolutionLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.YValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.XValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(426, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 141);
            this.panel1.TabIndex = 3;
            // 
            // Fps_Label
            // 
            this.Fps_Label.AutoSize = true;
            this.Fps_Label.Location = new System.Drawing.Point(85, 102);
            this.Fps_Label.Name = "Fps_Label";
            this.Fps_Label.Size = new System.Drawing.Size(0, 13);
            this.Fps_Label.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Framerate:";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(85, 79);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(0, 13);
            this.ResolutionLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution: ";
            // 
            // YValue
            // 
            this.YValue.AutoSize = true;
            this.YValue.Location = new System.Drawing.Point(39, 49);
            this.YValue.Name = "YValue";
            this.YValue.Size = new System.Drawing.Size(41, 13);
            this.YValue.TabIndex = 3;
            this.YValue.Text = "YValue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y: ";
            // 
            // XValue
            // 
            this.XValue.AutoSize = true;
            this.XValue.Location = new System.Drawing.Point(39, 17);
            this.XValue.Name = "XValue";
            this.XValue.Size = new System.Drawing.Size(41, 13);
            this.XValue.TabIndex = 1;
            this.XValue.Text = "XValue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X: ";
            // 
            // ControlCursor_chkBox
            // 
            this.ControlCursor_chkBox.AutoSize = true;
            this.ControlCursor_chkBox.Location = new System.Drawing.Point(64, 439);
            this.ControlCursor_chkBox.Name = "ControlCursor_chkBox";
            this.ControlCursor_chkBox.Size = new System.Drawing.Size(94, 17);
            this.ControlCursor_chkBox.TabIndex = 4;
            this.ControlCursor_chkBox.Text = "Controll Cursor";
            this.ControlCursor_chkBox.UseVisualStyleBackColor = true;
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Settings_Panel.Location = new System.Drawing.Point(426, 30);
            this.Settings_Panel.Name = "Settings_Panel";
            this.Settings_Panel.SelectedSettings = null;
            this.Settings_Panel.Size = new System.Drawing.Size(400, 261);
            this.Settings_Panel.TabIndex = 5;
            // 
            // ParallellMode_checkBox
            // 
            this.ParallellMode_checkBox.AutoSize = true;
            this.ParallellMode_checkBox.Location = new System.Drawing.Point(64, 412);
            this.ParallellMode_checkBox.Name = "ParallellMode_checkBox";
            this.ParallellMode_checkBox.Size = new System.Drawing.Size(91, 17);
            this.ParallellMode_checkBox.TabIndex = 6;
            this.ParallellMode_checkBox.Text = "Parallell mode";
            this.ParallellMode_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 524);
            this.Controls.Add(this.ParallellMode_checkBox);
            this.Controls.Add(this.Settings_Panel);
            this.Controls.Add(this.ControlCursor_chkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.inputDropDown);
            this.Controls.Add(this.displayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.ComboBox inputDropDown;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label XValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ControlCursor_chkBox;
        private Panels.SettingsPanel Settings_Panel;
        private System.Windows.Forms.Label Fps_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ParallellMode_checkBox;
    }
}

