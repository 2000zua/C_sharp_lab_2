using System.Drawing;
using System.Windows.Forms;

namespace FormsApp.views
{
    public partial class Form_task_1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private Pen pen;
        private bool drawing;


        public Form_task_1()
        {
            InitializeComponent();
            this.pen = new Pen(Color.Black, 2);
            this.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            this.DoubleBuffered = true;
            this.Size = new Size(900, 900);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Paint += new PaintEventHandler(Form_task_1_Paint);
            this.MouseDown += new MouseEventHandler(Form_task_1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form_task_1_MouseUp);

            this.Text = "Dotted Line Drawing App";
        }

        private void Form_task_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.endPoint = e.Location;
                this.drawing = false;
                this.Invalidate();
            }
        }

        private void Form_task_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.startPoint = e.Location;
                this.endPoint = e.Location;
                this.drawing = true;
            }
        }

        private void Form_task_1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
    }
}
