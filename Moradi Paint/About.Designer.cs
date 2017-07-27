namespace Moradi_Paint
{
    partial class About
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
            this.faderTheme1 = new Fader_Theme.FaderTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.faderControlBox1 = new Fader_Theme.FaderControlBox();
            this.faderTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // faderTheme1
            // 
            this.faderTheme1.Controls.Add(this.faderControlBox1);
            this.faderTheme1.Controls.Add(this.pictureBox1);
            this.faderTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center;
            this.faderTheme1.Icon = null;
            this.faderTheme1.Location = new System.Drawing.Point(0, 0);
            this.faderTheme1.Name = "faderTheme1";
            this.faderTheme1.ShowHeader = true;
            this.faderTheme1.ShowIcon = true;
            this.faderTheme1.Size = new System.Drawing.Size(589, 461);
            this.faderTheme1.TabIndex = 0;
            this.faderTheme1.Text = "Moradi Paint";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moradi_Paint.Properties.Resources.imageedit_20_4434715550;
            this.pictureBox1.Location = new System.Drawing.Point(16, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // faderControlBox1
            // 
            this.faderControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faderControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.faderControlBox1.Location = new System.Drawing.Point(488, 12);
            this.faderControlBox1.MaximumDisable = false;
            this.faderControlBox1.MinimumDisable = false;
            this.faderControlBox1.Name = "faderControlBox1";
            this.faderControlBox1.Size = new System.Drawing.Size(85, 30);
            this.faderControlBox1.TabIndex = 1;
            this.faderControlBox1.Text = "faderControlBox1";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 461);
            this.Controls.Add(this.faderTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.faderTheme1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Fader_Theme.FaderTheme faderTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Fader_Theme.FaderControlBox faderControlBox1;
    }
}