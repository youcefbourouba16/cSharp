using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25032023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double a, b, c, delta;
            a=Convert.ToDouble(tbA.Text);
            b=Convert.ToDouble(tbB.Text);
            c=Convert.ToDouble(tbC.Text);
            if (a != 0)
            {
                delta = Math.Pow(b,2)-(4*a*c);

                if (delta>0)
                {
                    lbResultat.Text="Il existe deux solutions x1= "+(- b- Math.Sqrt(delta)) / (2 * a)
                        +"x2 : "+ (-b + Math.Sqrt(delta)) / (2 * a);
                }
                else if (delta==0) {
                    lbResultat.Text = "Il existe une solutions x1=x2" + "" +
                        (-b) / (2 * a);
                }
                else  lbResultat.Text= "Pas de solution !!!!";
            } 
            else {
                lbResultat.Text = "La valeur de A doit etre <> a Zero !!!!";
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";

        }

        private void btDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";

        }

        private void btCal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
