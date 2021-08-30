namespace lab5a
{
    partial class DrawForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.ColourButton = new System.Windows.Forms.Button();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.dropWaterFill);
            // 
            // ColourButton
            // 
            this.ColourButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ColourButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColourButton.Location = new System.Drawing.Point(26, 24);
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(110, 32);
            this.ColourButton.TabIndex = 0;
            this.ColourButton.Text = "Colour";
            this.ColourButton.UseVisualStyleBackColor = false;
            this.ColourButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Location = new System.Drawing.Point(26, 105);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(133, 69);
            this.TrackBar.TabIndex = 2;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(171, 25);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(110, 31);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.ErrorImage")));
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(26, 180);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(133, 103);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(518, 642);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ColourButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "DrawForm";
            this.Text = "A Drop in the Bucket";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

