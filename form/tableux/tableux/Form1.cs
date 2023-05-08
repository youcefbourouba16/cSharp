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
            btn.Location = new Point(80 * l, 40 * c);
            btn.Size = new Size(60, 30);
            btn.Text = "Somme";
            btn.Click += new System.EventHandler(btnSomme_Click);
            panel1.Controls.Add(btn);
        }

        private void btnSomme_Click(object? sender, EventArgs e)
        {
            double somme = 0;
            
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    string str1 = "", str2 = "";
                    string str = c.Name;
                    for (int i = 1; i < str.Length; i++)
                    {

                        if (str[i]!='c'){

                            str1 += str[i];

                        }else
                        {
                            for (int j = i+1; j < str.Length; j++)
                            {
                                str2 += str[j];
                            } break;
                        }

                        

                    }
                    if (str1 == str2)
                        {
                            somme += Convert.ToDouble(c.Text);
                        }
                    
                    
                }
            }
            MessageBox.Show("la Somme est : " + somme);
        }
    }
}
