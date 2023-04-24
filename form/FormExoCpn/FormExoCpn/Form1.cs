using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FormExoCpn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (Convert.ToInt32(tbN.Text) > Convert.ToInt32(tbP.Text))
            {
                int fnNP = 1, fnN = 1, fnP = 1;
                double cpn;


                for (int i = 1; i <= Convert.ToInt32(tbN.Text); i++)
                {
                    fnN *= i;
                }
                for (int i = 1; i <= Convert.ToInt32(tbP.Text); i++)
                {
                    fnP *= i;
                }

                for (int i = 1; i <= (Convert.ToInt32(tbN.Text) - Convert.ToInt32(tbP.Text)); i++)
                {
                    fnNP *= i;
                }

                cpn = Convert.ToDouble(fnN) / Convert.ToDouble(fnP * fnNP);
                label4.Text = cpn.ToString();
                label5.Text = "N! = " + fnN.ToString();
                label6.Text = "P! = " + fnP.ToString();
                label7.Text = "(N-P)! = " + fnNP.ToString();












            }
            else if (Convert.ToInt32(tbN.Text) == Convert.ToInt32(tbP.Text))
            {
                label4.Text = "N doit etre different a P";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
            }
            else
            {
                label4.Text = "N doit etre supp a P";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
            }







        }

        private void tbP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;

            }

        }

        private void tbN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

