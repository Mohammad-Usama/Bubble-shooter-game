using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleShooter
{
    class Bubble : Label
    {
        public Bubble()
        {
            base.AutoSize = false;
            base.Text = "";
            base.Size = new Size(30, 30);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, base.Width, base.Height);
            base.Image = Image.FromFile("D:\\Course\\BS-V\\VP\\CSharp\\SemesterProject\\BubbleShooter\\usama\\New folder\\1.png");
            base.Region = new Region(path);
        }
    }
}
