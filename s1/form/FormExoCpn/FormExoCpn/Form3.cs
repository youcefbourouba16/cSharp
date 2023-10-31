using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExoCpn
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void results_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pf = 1, nf = 1,npf=1 ;
            if (Convert.ToInt16(n1.Text) > Convert.ToInt16(p1.Text))
            {
                for(int i=1;i<= (Convert.ToInt16(n1.Text) - Convert.ToInt16(p1.Text));i++)
                {
                    npf *= i;
                }
                if (Convert.ToInt16(p1.Text) > 0)

                {

                    for (int i = 1; i <= Convert.ToInt16(p1.Text); i++)
                    {
                        pf *= i;
                    }
                }
                else results.Text = "p doit etre sup a 0";
                if (Convert.ToInt16(n1.Text) > 0)

                {

                    for (int i = 1; i <= Convert.ToInt16(n1.Text); i++)
                    {
                        nf *= i;
                    }
                }
                else results.Text = "N doit etre sup a 0";

            }
            else results.Text = "N doit etre supp a p ";

            double m =Convert.ToDouble(nf) / (npf * pf);

            results.Text = Convert.ToString(m);
            labelP.Text = Convert.ToString(npf);
            
        }
    }
}
