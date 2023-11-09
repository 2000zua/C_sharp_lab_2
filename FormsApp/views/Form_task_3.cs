using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_3 : Form
    {
        private Color fillColor = Color.Yellow;
        private Color borderColor = Color.Red;
        private int borderThickness = 2;
        private Point startPoint;
        private Point endPoint;
        private bool drawing;

        public Form_task_3()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            this.BackColor = Color.White;

            this.MouseDown += new MouseEventHandler(Form_task_3_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_task_3_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_task_3_MouseUp);

            this.Text = "Ellipse Drawing App";

        }

        private void Form_task_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                endPoint = e.Location;
                drawing = true;
            }
        }

        private void Form_task_3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                this.Invalidate();
            }
        }

        private void Form_task_3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                drawing = false;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (drawing)
            {
                using (Graphics g = e.Graphics)
                {
                    Rectangle rect = new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                    SolidBrush fillBrush = new SolidBrush(fillColor);
                    Pen borderPen = new Pen(borderColor, borderThickness);

                    g.FillEllipse(fillBrush, rect);
                    g.DrawEllipse(borderPen, rect);
                }
            }
        }

    }
}
