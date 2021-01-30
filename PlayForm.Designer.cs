namespace BubbleShooter
{
   partial class PlayForm
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
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlay.Image = global::BubbleShooter.Properties.Resources.playbutton;
            this.lblPlay.Location = new System.Drawing.Point(-1, 88);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(193, 178);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Transparent;
            this.lblClose.Image = global::BubbleShooter.Properties.Resources.cross;
            this.lblClose.Location = new System.Drawing.Point(658, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(40, 37);
            this.lblClose.TabIndex = 1;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BubbleShooter.Properties.Resources.cover;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubble Shooter";
            this.Load += new System.EventHandler(this.PlayForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblClose;

    }
}
    