using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPProjectorDisplay
{
    public partial class Form1 : Form
    {
        Graphics Canvas;

        public Form1()
        {
            InitializeComponent();
            Canvas = CanvasPanel.CreateGraphics();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Render();
            Thread.Sleep(1000);
            Render();
        }

        void Render()
        {
            Graphics g = null;
            Graphics Canvas;
            BufferedGraphicsContext rc;
            rc = BufferedGraphicsManager.Current;
            BufferedGraphics rg = null;
            g = CanvasPanel.CreateGraphics();
            rg = rc.Allocate(g, CanvasPanel.DisplayRectangle);
            Canvas = rg.Graphics;
            Canvas.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            Canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            Canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            Canvas.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            Canvas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            /////////////////
            /////////////////Drawing code here
            /////////////////

            Canvas.Clear(Color.Black);

            for(int i =0; i < 128; i++)
            {
                Canvas.DrawLine(new Pen(Color.FromArgb(50,50,50)), i * 3, 0, i * 3, 128 * 3);
                Canvas.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), 0, i*3, 128*3, i * 3);
            }


            if (rg != null)
            {
                rg.Render(g);
            }

            if (rg != null)
            {
                //rg.Dispose();
            }
            if (g != null)
            {
                g.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }
    }
}
