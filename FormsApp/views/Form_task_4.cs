using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_4 : Form
    {
        private List<Point> trianglePoints;
        private Rectangle rectangle;


        public Form_task_4()
        {
            InitializeComponent();

            this.Text = "Triangle Drawing App";
            trianglePoints = new List<Point>();

            this.MouseClick += Form_task_4_MouseClick;
            this.Paint += Form_task_4_Paint;
        }

        private void Form_task_4_MouseClick(object sender, MouseEventArgs e)
        {
            trianglePoints.Add(new Point(e.X, e.Y));

            Size size = new Size(width: e.X/2, height: e.Y/3);
            rectangle = new Rectangle(e.Location, size);

            this.Invalidate();

            if (trianglePoints.Count == 3)
            {
                trianglePoints.Clear();
            }
        }

        private void Form_task_4_Paint(object sender, PaintEventArgs e)
        {

            if (trianglePoints.Count == 2)
            {
                e.Graphics.FillRectangle(Brushes.Blue, rectangle);
            }
            else if (trianglePoints.Count == 3)
            {
                e.Graphics.FillRectangle(Brushes.Red, rectangle);
            }
        }
    }
}
