using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25032023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ////methode 1
            //int x, y, som;
            //x = Convert.ToInt32(textBox1.Text);
            //y = Convert.ToInt32(textBox3.Text);
            //som = x + y;
            //label4.Text = label4.Text + "" + som.ToString(); //Convert.Tostring(som);


            //*********label4.Text = Convert.ToString((Convert.ToInt32(textBox1.Text) + (Convert.ToInt32(textBox3.Text))));********//////////
            if ((textBox1.Text)=="" || (textBox3.Text)=="")
            {
                label4.Text = "Veuillez entrer des valeurs X et Y .";
                return;
            }
            if (addition.Checked == true)
            {
                
                label4.Text = "la Somme est : " + Convert.ToString(Convert.ToDouble(textBox1.Text) +
                    Convert.ToDouble(textBox3.Text));



            } else if (multi.Checked == true)
            {
                label4.Text = "la multiplation est : " + Convert.ToString(Convert.ToDouble(textBox1.Text) *
                    Convert.ToDouble(textBox3.Text));
            }
            else if (subtration.Checked == true)
            {
                label4.Text = "la subtraction est : " + Convert.ToString(Convert.ToDouble(textBox1.Text) -
                    Convert.ToDouble(textBox3.Text));
            }
            else if (division.Checked == true)
            {

                double y = Convert.ToDouble(textBox3.Text);
                if (y == 0)
                {
                    label4.Text = "Error inserer une valeur different a Zero !!!";
                }
                else
                {
                    label4.Text = "la subtraction est : " + Convert.ToString(Convert.ToDouble(textBox1.Text) /
                        y);
                }

            }else if (fac.Checked == true)
            {
                int x = Convert.ToInt32(textBox1.Text);
                if ((textBox3.Text ==""))
                {
                    return;

                }
                else if (x < 0)
                {
                    label4.Text = "Enter une valeur (sup ou egal) Zero";

                }
                else
                {
                    int fact = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        fact *= i;

                    }
                    label4.Text = "le factorial de " + x + " est :" + fact;
                }
            }
            else
            {
                label4.Text = "plz selectionner une Operation .";
            }
            
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }

        private void addition_CheckedChanged(object sender, EventArgs e)
        {
            
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void subtration_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fac_CheckedChanged(object sender, EventArgs e)
        {
            if (fac.Checked==true)
            {
                label3.Visible= false;
                textBox3.Visible= false;
            }
            else
            {
                label3.Visible= true;
                textBox3.Visible= true;
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
