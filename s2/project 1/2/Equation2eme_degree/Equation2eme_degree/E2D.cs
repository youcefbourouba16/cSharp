using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation2eme_degree
{
    public class E2D

    {
        private double a, b, c;
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public E2D()
        {
        }
        public E2D(double b,double c)
        {
            try
            {
                double solutin = -c / b;
                MessageBox.Show("solution is :" + solutin);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                
            
            
        }


        public  E2D(double a, double b, double c)
        {

            double delta = Math.Pow(b, 2) - 4 * (a * c);

            if (a == 0) { MessageBox.Show("pick another number <> 0"); }
            else
            {

                if (delta > 0)
                {

                    MessageBox.Show("il exist two solutions :" + "resultat 1 = " + ((-b - Math.Sqrt(delta) / 2 * a)) + ", resultat 2= " + "   " + ((-b + Math.Sqrt(delta) / 2 * a)));
                }
                else if (delta == 0) { MessageBox.Show("solution doublee x1 = "+ (-b) / 2 * a); } else { MessageBox.Show("delta est moins de zero"); }
            }


        }

       
    }
}
