namespace HWiNFO64_Plugin
{
    partial class PluginConfigurationView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginConfigurationView));
            SaveSettingsButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            sensorsCountLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            izeLogo = new System.Windows.Forms.PictureBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            refreshTimeInput = new System.Windows.Forms.NumericUpDown();
            lameTimer = new System.Windows.Forms.Timer(components);
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)izeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refreshTimeInput).BeginInit();
            SuspendLayout();
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SaveSettingsButton.Location = new System.Drawing.Point(121, 141);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new System.Drawing.Size(134, 77);
            SaveSettingsButton.TabIndex = 0;
            SaveSettingsButton.Text = "Save Settings";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Found Sensors:";
            // 
            // sensorsCountLabel
            // 
            sensorsCountLabel.AutoSize = true;
            sensorsCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            sensorsCountLabel.ForeColor = System.Drawing.Color.White;
            sensorsCountLabel.Location = new System.Drawing.Point(118, 9);
            sensorsCountLabel.Name = "sensorsCountLabel";
            sensorsCountLabel.Size = new System.Drawing.Size(28, 15);
            sensorsCountLabel.TabIndex = 2;
            sensorsCountLabel.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Refresh interval:";
            // 
            // izeLogo
            // 
            izeLogo.BackColor = System.Drawing.Color.Transparent;
            izeLogo.Image = Properties.Resources.ize_small;
            izeLogo.Location = new System.Drawing.Point(51, 235);
            izeLogo.Name = "izeLogo";
            izeLogo.Size = new System.Drawing.Size(295, 163);
            izeLogo.TabIndex = 5;
            izeLogo.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            linkLabel1.Location = new System.Drawing.Point(239, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(131, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Powered by HWiNFO64";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.Black;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.Color.Red;
            textBox1.Location = new System.Drawing.Point(12, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(358, 59);
            textBox1.TabIndex = 7;
            textBox1.Text = "Important: Make sure you have HWiNFO64 installed and please restart Macro-Deck if you change any settings or add new sensors in HWiNFO64";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 426);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 15);
            label3.TabIndex = 8;
            label3.Text = "Icon by YellowIcon";
            // 
            // refreshTimeInput
            // 
            refreshTimeInput.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            refreshTimeInput.ForeColor = System.Drawing.Color.White;
            refreshTimeInput.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            refreshTimeInput.Location = new System.Drawing.Point(118, 35);
            refreshTimeInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            refreshTimeInput.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            refreshTimeInput.Name = "refreshTimeInput";
            refreshTimeInput.Size = new System.Drawing.Size(57, 23);
            refreshTimeInput.TabIndex = 9;
            refreshTimeInput.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lameTimer
            // 
            lameTimer.Enabled = true;
            lameTimer.Interval = 50;
            lameTimer.Tick += lameTimer_Tick;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = System.Drawing.Color.Cyan;
            linkLabel2.Location = new System.Drawing.Point(237, 35);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(133, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click here for setup info";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // PluginConfigurationView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(382, 450);
            Controls.Add(linkLabel2);
            Controls.Add(SaveSettingsButton);
            Controls.Add(refreshTimeInput);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(sensorsCountLabel);
            Controls.Add(label1);
            Controls.Add(izeLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PluginConfigurationView";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "HWiNFO64 Plugin Config";
            Shown += PluginConfigurationView_Shown;
            ((System.ComponentModel.ISupportInitialize)izeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)refreshTimeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sensorsCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox izeLogo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown refreshTimeInput;
        private System.Windows.Forms.Timer lameTimer;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}