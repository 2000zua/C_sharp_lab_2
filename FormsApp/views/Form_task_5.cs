using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_5 : Form
    {
        private List<Point> points = new List<Point>();
        private List<Point> lines = new List<Point>();
        private Pen pen = new Pen(Color.Black);
        private bool drawing;

        public Form_task_5()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MouseDown += new MouseEventHandler(Form_task_5_MouseDown);

            this.Text = "Polyline Drawing App";
        }

        private void Form_task_5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                drawing = true;

                if (points.Count >= 2)
                {
                    lines.Add(points[points.Count - 2]);
                    lines.Add(points[points.Count - 1]);
                }

                this.Invalidate();
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics g = e.Graphics)
            {
                g.DrawLines(pen, lines.ToArray());

                if (drawing)
                {
                    g.DrawLines(pen, points.ToArray());

                    if (points.Count >= 2)
                    {
                        g.DrawLine(pen, points[points.Count - 1], points[0]);
                    }
                }
            }
        }

    }
}
