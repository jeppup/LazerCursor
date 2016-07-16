namespace LazerCursor.Panels
{
    partial class SettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Threshold_TextBox = new System.Windows.Forms.TextBox();
            this.CursorScaling_TextBox = new System.Windows.Forms.TextBox();
            this.ColorMode_comboBox = new System.Windows.Forms.ComboBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.ClickThreshold_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LerpSteps_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lazer color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Threshold: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cursor movement factor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings";
            // 
            // Threshold_TextBox
            // 
            this.Threshold_TextBox.Location = new System.Drawing.Point(139, 77);
            this.Threshold_TextBox.Name = "Threshold_TextBox";
            this.Threshold_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Threshold_TextBox.TabIndex = 4;
            // 
            // CursorScaling_TextBox
            // 
            this.CursorScaling_TextBox.Location = new System.Drawing.Point(139, 103);
            this.CursorScaling_TextBox.Name = "CursorScaling_TextBox";
            this.CursorScaling_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CursorScaling_TextBox.TabIndex = 5;
            // 
            // ColorMode_comboBox
            // 
            this.ColorMode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorMode_comboBox.FormattingEnabled = true;
            this.ColorMode_comboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.ColorMode_comboBox.Location = new System.Drawing.Point(139, 50);
            this.ColorMode_comboBox.Name = "ColorMode_comboBox";
            this.ColorMode_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorMode_comboBox.TabIndex = 6;
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(255, 194);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // ClickThreshold_txtBox
            // 
            this.ClickThreshold_txtBox.Location = new System.Drawing.Point(139, 129);
            this.ClickThreshold_txtBox.Name = "ClickThreshold_txtBox";
            this.ClickThreshold_txtBox.Size = new System.Drawing.Size(100, 20);
            this.ClickThreshold_txtBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Click Threshold: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lerp steps: ";
            // 
            // LerpSteps_txtBox
            // 
            this.LerpSteps_txtBox.Location = new System.Drawing.Point(139, 160);
            this.LerpSteps_txtBox.Name = "LerpSteps_txtBox";
            this.LerpSteps_txtBox.Size = new System.Drawing.Size(100, 20);
            this.LerpSteps_txtBox.TabIndex = 11;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LerpSteps_txtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClickThreshold_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.ColorMode_comboBox);
            this.Controls.Add(this.CursorScaling_TextBox);
            this.Controls.Add(this.Threshold_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(347, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Threshold_TextBox;
        private System.Windows.Forms.TextBox CursorScaling_TextBox;
        private System.Windows.Forms.ComboBox ColorMode_comboBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.TextBox ClickThreshold_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LerpSteps_txtBox;
    }
}
