namespace BubbleShooter
{
    partial class frmBubbbleShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBubbbleShooter));
            this.controlPane = new System.Windows.Forms.Panel();
            this.lblRestart = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblPromptScore = new System.Windows.Forms.Label();
            this.bubbleShootTimer = new System.Windows.Forms.Timer(this.components);
            this.lblArrow = new System.Windows.Forms.Label();
            this.arrowMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.controlPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPane
            // 
            this.controlPane.BackColor = System.Drawing.Color.Transparent;
            this.controlPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPane.Controls.Add(this.lblRestart);
            this.controlPane.Controls.Add(this.lblScoreCount);
            this.controlPane.Controls.Add(this.lblPromptScore);
            this.controlPane.Location = new System.Drawing.Point(1, 478);
            this.controlPane.Name = "controlPane";
            this.controlPane.Size = new System.Drawing.Size(430, 62);
            this.controlPane.TabIndex = 1;
            this.controlPane.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPane_Paint);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblRestart.Location = new System.Drawing.Point(10, 29);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(70, 23);
            this.lblRestart.TabIndex = 2;
            this.lblRestart.Text = "Restart";
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.Location = new System.Drawing.Point(355, 29);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(29, 20);
            this.lblScoreCount.TabIndex = 1;
            this.lblScoreCount.Text = "00";
            // 
            // lblPromptScore
            // 
            this.lblPromptScore.AutoSize = true;
            this.lblPromptScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPromptScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPromptScore.Location = new System.Drawing.Point(346, 13);
            this.lblPromptScore.Name = "lblPromptScore";
            this.lblPromptScore.Size = new System.Drawing.Size(49, 16);
            this.lblPromptScore.TabIndex = 0;
            this.lblPromptScore.Text = "Score";
            // 
            // bubbleShootTimer
            // 
            this.bubbleShootTimer.Tick += new System.EventHandler(this.bubbleShootTimer_Tick);
            // 
            // lblArrow
            // 
            this.lblArrow.BackColor = System.Drawing.Color.Transparent;
            this.lblArrow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblArrow.Image = ((System.Drawing.Image)(resources.GetObject("lblArrow.Image")));
            this.lblArrow.Location = new System.Drawing.Point(192, 427);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(38, 48);
            this.lblArrow.TabIndex = 2;
            this.lblArrow.Click += new System.EventHandler(this.lblArrow_Click);
            // 
            // arrowMovementTimer
            // 
            this.arrowMovementTimer.Tick += new System.EventHandler(this.arrowMovementTimer_Tick);
            // 
            // frmBubbbleShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 537);
            this.Controls.Add(this.controlPane);
            this.Controls.Add(this.lblArrow);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 576);
            this.Name = "frmBubbbleShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBubbbleShooter_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.controlPane.ResumeLayout(false);
            this.controlPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPane;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblPromptScore;
        private System.Windows.Forms.Timer bubbleShootTimer;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Timer arrowMovementTimer;
        private System.Windows.Forms.Label lblRestart;
    }
}

