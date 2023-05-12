using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace tableux
{
    public partial class Form1 : Form
    {

        double[,] Matrice = new double[50, 50];
        double max, min;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int l = Convert.ToInt32(tb1.Text);
            int c = Convert.ToInt32(tb2.Text);

            TextBox tb;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    tb = new TextBox();
                    tb.Text = "0";
                    tb.Name = "l" + i + "c" + j;
                    tb.Size = new Size(60, 40);

                    tb.Location = new Point(i * 70, j * 50);

                    panel1.Controls.Add(tb);

                }

            }
            Button btn = new Button();
            btn.Location = new Point(70* l, 50 * c);
            btn.Size = new Size(60, 30);
            btn.Text = "Somme";
            btn.Click += new System.EventHandler(btnSomme_Click);
            panel1.Controls.Add(btn);
        }

        private void btnSomme_Click(object? sender, EventArgs e)

        {
            
            double somme = 0, somme1 = 0;
            double max, min;

            foreach (Control c in panel1.Controls)
            {
                
                if (c is TextBox)
                {
                    string str1 = "", str2 = "";
                    string str = c.Name;
                    
                    for (int i = 1; i < str.Length; i++)
                    {


                        if (str[i] != 'c')
                        {

                            str1 += str[i];

                        }
                        else
                        {
                            for (int j = i + 1; j < str.Length; j++)
                            {
                                str2 += str[j];
                            }
                            break;
                        }
                        if (str1 == Convert.ToString(1))
                        {
                            somme1 += Convert.ToDouble(c.Text);
                        }
                        /////hna drt la somme tae diagonal brk 
                    }
                    
                    if (str1 == str2)
                    {
                        somme += Convert.ToDouble(c.Text);
                    }
                    int m = Convert.ToInt32(str1);
                    int n = Convert.ToInt32(str2);
                    Matrice[m, n] = Convert.ToInt32(c.Text);

                }

            }
            MessageBox.Show("la Somme est : " + somme);
            int l = Convert.ToInt32(tb1.Text);
            int f = Convert.ToInt32(tb2.Text);
            for (int i = 0; i < l; i++)
            {
                max = Matrice[i, 0];
                min = Matrice[i, 0];
                for (int j = 0; j < f; j++)
                {
                    if (Matrice[i,j]>max)
                    {
                        max = Matrice[i, j];
                    }
                    if (Matrice[i, j] <min)
                    {
                        min = Matrice[i, j];
                    }
                }
                Label lb = new Label();
                lb.Text = "Min = " + min;
                lb.Name = "min" + i;
                lb.Size = new Size(60, 40);

                lb.Location = new Point(f * 70, 50 * i);
                panel1.Controls.Add(lb);


                Label lb1 = new Label();
                lb1.Text = "Max = " + max;
                lb1.Name = "max" + i;
                lb1.Size = new Size(60, 40);

                lb1.Location = new Point((f + 1) * 70, 50 * i);

                panel1.Controls.Add(lb1);

            }
            

        }
    }
}
