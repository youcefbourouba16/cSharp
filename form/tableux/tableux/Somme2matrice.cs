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
    public partial class Somme2matrice : Form
    {
        public Somme2matrice()
        {
            InitializeComponent();
        }
        int[,] mat1 = new int[10, 10];
        int[,] mat2 = new int[10, 10];


        ///fonction addbox fl panel
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


                }

            }
        }

        /////ndir fonction t3amer la matrice w tkhrdjlna str1=j w str2=i
        public int[,] remlissage_matrice(Panel pl)
        {
            int[,] mat = new int[5, 5];
            foreach (Control m in pl.Controls)
            {
                if (m is TextBox)
                {
                    string str1 = "", str2 = "";
                    string str = m.Name;


                    str1 = str.Substring(1, str.IndexOf('c') - 1);
                    str2 = str.Substring(str.IndexOf('c') + 1);
                    mat[Convert.ToInt32(str2), Convert.ToInt32(str1)] = Convert.ToInt32(m.Text);

                }
            }
            return mat;
        }



        ///panel 2 khdmna fih text boxes f panel 2
        ///khdmna bl fonction add text box 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show(" entre les valeur svp !!");

            else
            {
                panel3.Controls.Clear();
                panel1.Controls.Clear();
                int l = Convert.ToInt32(textBox1.Text);
                int c = Convert.ToInt32(textBox2.Text);
                addtextbox(panel1, l, c);

            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "") MessageBox.Show(" entre les valeur svp !!");

            else
            {
                panel3.Controls.Clear();
                panel2.Controls.Clear();
                int l = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
                addtextbox(panel2, l, c);
            }
            Button btn = new Button();
            btn.Location = new Point(80, 60);
            btn.Size = new Size(100, 70);
            btn.Text = "CALCULER LA SOMME";
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.Red;
            btn.Click += new System.EventHandler(btnCalcul_Click);

            panel3.Controls.Add(btn);
        }

        private void btnCalcul_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text == textBox3.Text && textBox1.Text == textBox3.Text)
            {
                panel3.Controls.Clear();
                mat1 = remlissage_matrice(panel1);
                mat2 = remlissage_matrice(panel2);
                
                int[,] matsome = new int[5, 5];
                for (int i = 0; i < Convert.ToInt16(textBox1.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt16(textBox2.Text); j++)
                    {
                       
                        matsome[i, j] = mat1[i, j] + mat2[i, j];
                    }
                }
                
                

                addtextbox(panel3, Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));


                foreach (Control m in panel3.Controls)
                {
                    if (m is TextBox)
                    {
                        string str1 = "", str2 = "";
                        string str = m.Name;


                        str1 = str.Substring(1, str.IndexOf('c') - 1);
                        str2 = str.Substring(str.IndexOf('c') + 1);
                        m.Text = Convert.ToString(matsome[Convert.ToInt16(str2), Convert.ToInt16(str1)]);
                        
                    }
                    
                }


            }
            else MessageBox.Show("le nombre de ligne et collone de la matrcie 1 doit etre egal " +
                "a le nombre de ligne et collone de la matrcie 2 !!!");



        }


    }




}
