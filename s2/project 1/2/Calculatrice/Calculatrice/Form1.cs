using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int virgulCount = 0;
        private double calculate(string s) { 
            return Convert.ToDouble(new System.Data.DataTable().Compute(s,""));
        }
        private void btn_multipl_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (tb_affiche.Text == "0")   tb_affiche.Text = "";
            tb_affiche.Text += btn.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            tb_affiche.Text = "0";
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            
            tb_affiche.Text = Convert.ToString(calculate(tb_affiche.Text));
        }

        private void btnvi_Click(object sender, EventArgs e)
        {
            if (virgulCount==0) tb_affiche.Text += ".";
            virgulCount =1;
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (tb_affiche.Text == "0") tb_affiche.Text = "";
            tb_affiche.Text += btn.Text;
            virgulCount = 0;
        }

        private void tb_affiche_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
