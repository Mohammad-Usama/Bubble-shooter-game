using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleShooter
{
    public partial class PlayForm : Form
    {
        frmBubbbleShooter f = new frmBubbbleShooter();
        System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"D:\Course\BS-V\VP\BubbleShooter\Sound.wav");

        public PlayForm()
        {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            //this.lblPlay.Image = System.Drawing.Image.FromFile(@"D:\Course\BS-V\VP\BubbleShooter\playbutton.png");
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            startSound.Stop();
            this.Hide();
            f.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayForm_Load_1(object sender, EventArgs e)
        {
            
            startSound.PlayLooping();

        }

    }
}
