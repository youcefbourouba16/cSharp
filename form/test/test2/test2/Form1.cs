using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcul_Click(object sender, EventArgs e)

        {
            panel1.Controls.Clear();

            int l = Convert.ToInt32(tb_C.Text);
            int c= Convert.ToInt32(tb_L.Text);
            TextBox tb = new TextBox();
            for (int j = 0; j < c; j++)
            {
                for (int i = 0; i < l; i++)
                {

                    tb = new TextBox();
                    tb.Text = "L" + j + "C"+i;
                    tb.Size = new Size(50, 30);
                    tb.Location = new Point(60 * i, 40 * j);
                    panel1.Controls.Add(tb);

                }




            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
