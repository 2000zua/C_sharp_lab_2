using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_4 : Form
    {
        private List<Point> points = new List<Point>();
        private Pen pen = new Pen(Color.Black);
        private int clickCount = 0;

        public Form_task_4()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MouseDown += new MouseEventHandler(Form_task_4_MouseDown);

            this.Text = "Triangle Drawing App";
        }

        private void Form_task_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                clickCount++;

                if (clickCount >= 3)
                {
                    this.Invalidate();
                    clickCount = 0;
                }
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics g = e.Graphics)
            {
                for (int i = 0; i < points.Count - 2; i += 3)
                {
                    Point p1 = points[i];
                    Point p2 = points[i + 1];
                    Point p3 = points[i + 2];

                    g.DrawLine(pen, p1, p2);
                    g.DrawLine(pen, p2, p3);
                    g.DrawLine(pen, p3, p1);
                }
            }
        }

    }
}
