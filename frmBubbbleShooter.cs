using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Shapes;

namespace BubbleShooter
{
    public partial class frmBubbbleShooter : Form
    {
        Color[] bubbleColor = { Color.Red, Color.Blue, Color.Yellow, Color.LawnGreen, Color.MediumOrchid, Color.LawnGreen };
        Color inColor = new Color();
        Bubble[,] bubbles = new Bubble[50, 50];
        Bubble shootBubble = new Bubble();
       
        Bubble movingBubble = new Bubble();
        Random rand = new Random();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Course\BS-V\VP\BubbleShooter\Glassbreaking.wav");
        System.Media.SoundPlayer missPlayer = new System.Media.SoundPlayer(@"D:\Course\BS-V\VP\BubbleShooter\Bubblesplash.wav");
        bool flag = true;
        int x = 0;
        int Time = 0;
        int checkEven = 0;
        int xValue = 0;

        public frmBubbbleShooter()
        {
            
            InitializeComponent();
           
            
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    bubbles[i, j] = new Bubble();

            start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bubble Shooter";
            arrowMovementTimer.Interval = 15;
            arrowMovementTimer.Start();
        }
        private void btnCircle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void controlPane_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Up)
            {
                
                x = lblArrow.Location.X + 3;
               
                movingBubble.Location = new Point(x, this.lblArrow.Location.Y-40);
                movingBubble.Size = new Size(32, 32);
                movingBubble.BackColor = shootBubble.BackColor;
                movingBubble.Visible = true;
                this.Controls.Add(movingBubble);
                shootBubble.BackColor = bubbleColor[rand.Next(6)];
               

                bubbleShootTimer.Interval = 20;
                bubbleShootTimer.Start();
            }
        }

        private void bubbleShootTimer_Tick(object sender, EventArgs e)
        {
            Time++;
            // i is row 
            movingBubble.Location = new Point(x, this.movingBubble.Location.Y - 5);
            // j is column
            for (int j = 12; j>=0; j--)
            {
                for (int i = 11; i >= 0; i--)
                {
                     
                    if (bubbles[i, j].Bounds.IntersectsWith(movingBubble.Bounds))
                    {
                       
                        movingBubble.BringToFront();
                        bubbles[i, j].SendToBack();

                        if (bubbles[i, j].Visible)
                        {
                            bubbleShootTimer.Stop();
                        
                            if (bubbles[i, j].BackColor == movingBubble.BackColor)
                            {
                                
                                player.Play();
                                bubbles[i, j].Hide();
                                this.lblScoreCount.Text = ""+(Convert.ToInt32(this.lblScoreCount.Text) + 10);
                                bubbles[i, j].Visible = false;
                                bubbles[i, j].BackColor = Color.Black;
                                
                            }
                            else if (bubbles[i, j].Visible)
                            {
                                missPlayer.Play();
                                this.lblScoreCount.Text = "" + (Convert.ToInt32(this.lblScoreCount.Text) - 5);
                                bubbles[i + 1, j].Visible = true;
                                bubbles[i + 1, j].BackColor = movingBubble.BackColor;                                
                            }
                            this.Controls.Remove(movingBubble);   
                        }
                        

                        return;
                    }
                }
            }
            

        }
        

        private void arrowMovementTimer_Tick(object sender, EventArgs e)
        {
            
            if (lblArrow.Location.X > 390)
                flag = false;
            if (lblArrow.Location.X < 2)
                flag = true;
           
            if (flag)
                lblArrow.Location = new Point(lblArrow.Location.X + 3, 427);
            else
            {
                lblArrow.Location = new Point(lblArrow.Location.X - 3, 427);
            }
            
        }

        private void lblArrow_Click(object sender, EventArgs e)
        {

        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            start();
        }

        public void start()

        {
            int xIndex = 0;
            int yIndex = 0;
            this.lblScoreCount.Text = "00";
            for (int y = 0; y <= this.Size.Height; y += 35)
            {

                checkEven++;
                xValue = 0;

               // to draw another pattern of bubbles
                //if (checkEven % 2 == 0)
                //    xValue = 16;
                //else
                //    xValue = 0;
                for (int x = xValue; x < 414; x += 35)
                {
                    if (y <= 305)
                    {
                        bubbles[xIndex, yIndex].Visible = true;
                        bubbles[xIndex, yIndex].BackColor = bubbleColor[rand.Next(6)];

                    }
                    else
                    {

                        bubbles[xIndex, yIndex].Visible = false;
                        bubbles[xIndex, yIndex].BackColor = Color.Black;
                    }
                    bubbles[xIndex, yIndex].Location = new Point(x, y);
                    this.Controls.Add(bubbles[xIndex, yIndex]);

                    yIndex++;
                }
                xIndex++;
                yIndex = 0;

            }


            shootBubble.Location = new Point(this.controlPane.Width / 2 - 10, 0);
            shootBubble.BackColor = bubbleColor[rand.Next(6)];
            this.controlPane.Controls.Add(shootBubble);
           
        }

        private void frmBubbbleShooter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
