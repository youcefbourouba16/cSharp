using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SECONDS : Form
    {
        public SECONDS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int s, h,r,m,n;
            s = Convert.ToInt32(txt1.Text);
            h = s / 3600;
            r = s % 3600;
            m = r / 60;
            n=r % 60;

            label2.Text = label2.Text + h.ToString();
            label3.Text= label3.Text + m.ToString();
            label4.Text = label4.Text + n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "hour :" ;
            label3.Text = "minutes:";
            label4.Text = "seconds :";

        }
    }
}
