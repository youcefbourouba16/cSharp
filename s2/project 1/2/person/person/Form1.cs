using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person pr1 = new Person(textBox1.Text,
                textBox2.Text,
                Convert.ToInt32(textBox4.Text),
                textBox3.Text);
            Person pr2 = new Person("bourouba",
                "youcef",
                867867867,
                "fsdkfjksdjf");


            MessageBox.Show(pr2.Nom);
        }
    }
}
