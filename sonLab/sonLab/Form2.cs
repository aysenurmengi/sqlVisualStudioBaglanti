using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.User);
            // TODO: This line of code loads data into the 'dataSet1.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.dataSet1.Task);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int.TryParse(this.textBox1.Text, out value);
            this.userTableAdapter.Insert(value, textBox2.Text, textBox3.Text, textBox4.Text);
            this.userTableAdapter.Fill(this.dataSet1.User);
        }
    }
}
