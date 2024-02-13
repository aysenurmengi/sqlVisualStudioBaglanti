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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.User);
            // TODO: This line of code loads data into the 'dataSet1.Character' table. You can move, or remove it, as needed.
            this.characterTableAdapter.Fill(this.dataSet1.Character);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            this.characterTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, vp2);
            this.characterTableAdapter.Fill(this.dataSet1.Character);
        }
    }
}
