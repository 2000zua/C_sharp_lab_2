using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_2 : Form
    {
        private Color backgroundColor = Color.Blue;
        private Color snowflakeColor = Color.White;
        private int snowflakeRadius = 20;

        public Form_task_2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = backgroundColor;
            this.MouseClick += new MouseEventHandler(Form_task_2_MouseClick);
            this.Text = "Snowflake Drawing App";
        }

        private void Form_task_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point clickLocation = e.Location;
                DrawSnowflake(clickLocation);
            }
        }

        private void DrawSnowflake(Point center)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (int i = 0; i < 8; i++)
                {
                    double angle = i * Math.PI / 4;
                    int x = center.X + (int)(snowflakeRadius * Math.Cos(angle));
                    int y = center.Y + (int)(snowflakeRadius * Math.Sin(angle));
                    Point endPoint = new Point(x, y);
                    g.DrawLine(new Pen(snowflakeColor, 2), center, endPoint);
                }
            }
        }

    }
}
