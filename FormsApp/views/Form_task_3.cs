using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_3 : Form
    {
        private Graphics graphics;
        public Form_task_3()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            this.BackColor = Color.White;
            this.Text = "Ellipse Drawing App";
            this.MouseClick += (sender, e) => Mostar(this, e.Location); 
        }

        void Mostar(Control controle, Point ponto)
        {
            DrwawingEllipse(ponto.X, ponto.Y);
        }


        void DrwawingEllipse(int pointX, int pointY)
        {
            label3.Text = "Click in the screen to get posicio";
            graphics = CreateGraphics();
            graphics.FillEllipse(Brushes.Blue, pointX, pointY, pointX/2, pointY/3);
            label3.Enabled = true;
            label1.Text = "The point X: " + pointX;
            label2.Text = "The point Y: " + pointY;
        }
    }
}
