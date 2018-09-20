using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Breakout
{
    public partial class Form1 : Form
    {
        Vector ballPos;
        int ballRadius;

        public Form1()
        {
            InitializeComponent();

            this.ballPos = new Vector(200, 200);
            this.ballRadius = 10;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            SolidBrush pinkBrush = new SolidBrush(Color.HotPink);

            float px = (float)this.ballPos.X - ballRadius;
            float py = (float)this.ballPos.Y - ballRadius;

            e.Graphics.FillEllipse(pinkBrush, px, py, this.ballRadius * 2, this.ballRadius * 2);
        }
    }
}
