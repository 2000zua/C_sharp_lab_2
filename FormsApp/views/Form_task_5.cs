using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_5 : Form
    {
        private List<Point> polylinePoints;
        private Pen pen;

        public Form_task_5()
        {
            InitializeComponent();

            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            polylinePoints = new List<Point>();
            pen = new Pen(Color.Black);
            pen.Width = 2;

            this.Text = "Polyline Drawing App";

            this.MouseDoubleClick += Form_task_5_MouseDoubleClick;
            this.Paint += Form_task_5_Paint;
        }

        private void Form_task_5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            polylinePoints.Add(new Point(e.X, e.Y));

            this.Invalidate();

            if (polylinePoints.Count >= 2)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(pen, polylinePoints[0], polylinePoints[polylinePoints.Count - 1]);
            }

            if (polylinePoints.Count >= 3)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(pen, polylinePoints[polylinePoints.Count - 1], polylinePoints[0]);
            }
        }

        private void Form_task_5_Paint(object sender, PaintEventArgs e)
        {
            if (polylinePoints.Count > 1)
            {
                e.Graphics.DrawLines(pen, polylinePoints.ToArray());
            }
        }
    }
}
