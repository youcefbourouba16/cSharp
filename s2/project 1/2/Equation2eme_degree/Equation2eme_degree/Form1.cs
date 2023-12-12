using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Equation2eme_degree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcu_Click(object sender, EventArgs e)
        { 
            try
            {
                double b = Convert.ToDouble(tb_B.Text);
                double c = Convert.ToDouble(tb_C.Text);
                if (rb_first_degree.Checked || tb_A.Text == "0")
                {

                    E2D bn = new E2D(b, c);
                    E2D kenza = new E2D(1, 2);
                    MessageBox.Show("fsdkf");
                }
                else
                {
                    double a = Convert.ToDouble(tb_A.Text);
                    E2D bn = new E2D(a, b, c);
                }

            }
            catch (Exception )
            {

                MessageBox.Show("SVP enter les valeur ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void rb_first_degree_CheckedChanged(object sender, EventArgs e)
        {
            tb_A.Enabled = false;
            label2.Enabled = false;
            tb_B.Text = "";
            tb_C.Text = "";
        }

        private void rd_second_deg_CheckedChanged(object sender, EventArgs e)
        {
            tb_A.Enabled = true;
            label2.Enabled = true;
            tb_B.Text = "";
            tb_C.Text = "";
            tb_A.Text = "";
        }

        /// <summary>
        /// validation digit and " , "
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && ((sender as TextBox).Text.IndexOf('.') != -1))
            {
                e.Handled = true;
            }
            if (!char.IsDigit(ch) && ch != 46)
            {
                e.Handled = true;
            }
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
                
            }
            
            
        }
    }
}
