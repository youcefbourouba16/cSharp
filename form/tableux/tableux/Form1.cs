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

        int[,] T = new int[50, 50];
        int max, min;
        public void addtextbox(Panel p1, int l, int c)
        {
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

                    p1.Controls.Add(tb);
                    Button btn = new Button();
                    btn.Location = new Point(70 * l, 50 * c);
                    btn.Size = new Size(60, 30);
                    btn.Text = "Somme";
                    btn.Click += new System.EventHandler(btnSomme_Click);
                    p1.Controls.Add(btn);

                }

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCollone.Text == "" || tbLigne.Text == "")  MessageBox.Show(" entre les valeur svp !!");
          
            else
            {
                panel1.Controls.Clear();
                int l = Convert.ToInt32(tbLigne.Text);
                int c = Convert.ToInt32(tbCollone.Text);
                addtextbox(panel1, l, c);
            }


        }

        private void btnSomme_Click(object? sender, EventArgs e)

        {

            int somme = 0;


            foreach (Control m in panel1.Controls)
            {

                if (m is TextBox)
                {

                    string str1 = "", str2 = "";
                    string str = m.Name;

                    //    for (int i = 1; i < str.Length; i++)
                    //    {


                    //        if (str[i] != 'c')
                    //        {

                    //            str1 += str[i];

                    //        }
                    //        else
                    //        {
                    //            for (int j = i + 1; j < str.Length; j++)
                    //            {
                    //                str2 += str[j];
                    //            }
                    //            break;
                    //        }
                    //        if (str1 == Convert.ToString(1))
                    //        {
                    //            somme1 += Convert.ToDouble(c.Text);
                    //        }
                    //        /////hna drt la somme tae diagonal brk 
                    //    }

                    //    if (str1 == str2)
                    //    {
                    //        somme += Convert.ToDouble(c.Text);
                    //    }
                    //    int m = Convert.ToInt32(str1);
                    //    int n = Convert.ToInt32(str2);
                    //    Matrice[n, m] = Convert.ToInt32(c.Text);
                    str1 = str.Substring(1, str.IndexOf('c') - 1);
                    str2 = str.Substring(str.IndexOf('c') + 1);

                    if (str1 == str2)
                    {
                        somme += Convert.ToInt32(m.Text);
                    }
                    /////hna drt la somme tae diagonal brk 

                    T[Convert.ToInt32(str2), Convert.ToInt32(str1)] = Convert.ToInt32(m.Text);







                }

            }
            MessageBox.Show("la Somme est : " + somme);
            int l = Convert.ToInt32(tbLigne.Text);
            int c = Convert.ToInt32(tbCollone.Text);

            for (int i = 0; i < l; i++)
            {
                int Min = T[i, 0];
                int Max = T[i, 0];

                for (int j = 0; j < c; j++)
                {
                    if (T[i, j] > Max)
                    {
                        Max = T[i, j];
                    }

                    if (T[i, j] < Min)
                    {
                        Min = T[i, j];
                    }


                }
                Label lb1 = new Label();
                lb1.Text = "Min = " + Min;
                lb1.Name = "min" + i;
                lb1.Size = new Size(60, 40);

                lb1.Location = new Point(c * 70, 50 * i);
                panel1.Controls.Add(lb1);


                Label lb2 = new Label();
                lb2.Text = "Max = " + Max;
                lb2.Name = "max" + i;
                lb2.Size = new Size(60, 40);

                lb2.Location = new Point((c + 1) * 70, 50 * i);

                panel1.Controls.Add(lb2);
            }









        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbLigne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
