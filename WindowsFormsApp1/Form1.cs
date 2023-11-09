using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.view;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_2_1_Click(object sender, EventArgs e)
        {
            Form_task_2_1 form_Task_2_1 = new Form_task_2_1();
            form_Task_2_1.Show();
            Console.WriteLine("Cliquei aqui");
        }

        private void btn_2_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_task_2_1 form_Task_2_1 = new Form_task_2_1();
            form_Task_2_1.Show();
            Console.WriteLine("Cliquei aqui");
        }
    }
}
