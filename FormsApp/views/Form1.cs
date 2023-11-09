using System;
using System.Windows.Forms;
using FormsApp.views;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_tarefa_1_Click(object sender, EventArgs e)
        {
            Form_task_1 form_Task_1 = new Form_task_1();
            form_Task_1.ShowDialog();
        }

        private void button_tarefa_2_Click(object sender, EventArgs e)
        {
            Form_task_2 form_Task_2 = new Form_task_2();
            form_Task_2.ShowDialog();
        }

        private void button_tarefa_3_Click(object sender, EventArgs e)
        {
            Form_task_3 form_Task_3 = new Form_task_3();
            form_Task_3.ShowDialog();
        }

        private void button_tarefa_4_Click(object sender, EventArgs e)
        {
            Form_task_4 form_Task_4 = new Form_task_4();
            form_Task_4.ShowDialog();
        }

        private void button_tarefa_5_Click(object sender, EventArgs e)
        {
            Form_task_5 form_Task_5 = new Form_task_5();
            form_Task_5.ShowDialog();
        }
    }
}
