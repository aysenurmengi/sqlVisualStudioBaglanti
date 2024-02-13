using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 user = new Form2();
            user.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 character = new Form3();
            character.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 item = new Form4();
            item.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 task = new Form5();
            task.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 flag = new Form6();
            flag.ShowDialog();
        }
    }
}
