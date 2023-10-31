namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
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


                }

            }
        }
        public void affich_Mat(Panel pl)
        {
            foreach (Control m in pl.Controls)
            {
                if (m is TextBox)
                {
                    string str1 = "", str2 = "";

                    string str = m.Name;
                    str1 = str.Substring(1, str.IndexOf('c') - 1);
                    str2 = str.Substring(str.IndexOf('c') + 1);
                    m.Text = Convert.ToString(T[Convert.ToInt16(str2), Convert.ToInt16(str1)]);

                }

            }
        }
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

        //public int[,] permutationlignee(int[,] t, int nbrC, int i1, int i2)
        //{
        //    for (int k = 0; k < nbrC; k++)
        //    {
        //        int tempo = t[i1, k];
        //        t[i1, k] = t[i2, k];
        //        t[i2, k] = tempo;
        //    }
        //    return t;
        //}



        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show(" entre les valeur svp !!");

                else
                {
                    panel1.Controls.Clear();
                    int l = Convert.ToInt32(textBox1.Text);
                    int c = Convert.ToInt32(textBox2.Text);
                    addtextbox(panel1, l, c);
                    Button btn = new Button();
                    btn.Location = new Point(70 * l, 50 * c);
                    btn.Size = new Size(60, 30);
                    btn.Text = "Execute";
                    btn.Click += new System.EventHandler(btnSomme_Click);
                    panel1.Controls.Add(btn);
                }


            }
        }
        private void btnSomme_Click(object? sender, EventArgs e)
        {
            T = remlissage_matrice(panel1);
            panel2.Controls.Clear();
            int l = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked == true)
            {
                if (tbL.Text == "" || tbL2.Text == "") MessageBox.Show(" entre les valeur svp de permutation ligne !!");
                else if (Convert.ToInt16(tbL.Text) > Convert.ToInt16(textBox1.Text) || Convert.ToInt16(tbL2.Text) > Convert.ToInt16(textBox1.Text)) MessageBox.Show(" les valeur doit etre entre 0 et" + Convert.ToString(Convert.ToInt16(textBox1.Text)-1));

                else
                {
                    panel2.Controls.Clear();
                    //T = permutationlignee(T, Convert.ToInt32(tbL.Text), Convert.ToInt32(tbL.Text), Convert.ToInt32(tbL.Text));
                    for (int k = 0; k < Convert.ToInt16(textBox2.Text); k++)
                    {
                        int tempo = T[Convert.ToInt32(tbL.Text), k];
                        T[Convert.ToInt32(tbL.Text), k] = T[Convert.ToInt32(tbL2.Text), k];
                        T[Convert.ToInt32(tbL2.Text), k] = tempo;
                    }

                    addtextbox(panel2, l, c);
                    affich_Mat(panel2);


                }

            }
            else if (radioButton2.Checked == true)
            {
                if (tbC.Text == "" || tbC2.Text == "") MessageBox.Show(" entre les valeur svp de permutation collones !!");
                else if (Convert.ToInt16(tbC.Text) > Convert.ToInt16(textBox2.Text) || Convert.ToInt16(tbC2.Text) > Convert.ToInt16(textBox2.Text)) MessageBox.Show(" les valeur doit etre entre 0 et"+ Convert.ToString(Convert.ToInt16(textBox2.Text) - 1));
                else
                {
                    panel2.Controls.Clear();
                    //T = permutationlignee(T, Convert.ToInt32(tbL.Text), Convert.ToInt32(tbL.Text), Convert.ToInt32(tbL.Text));
                    for (int k = 0; k < Convert.ToInt16(textBox1.Text); k++)
                    {
                        int tempo = T[k, Convert.ToInt32(tbC.Text)];
                        T[k, Convert.ToInt32(tbC.Text)] = T[k, Convert.ToInt32(tbC2.Text)];
                        T[k, Convert.ToInt32(tbC2.Text)] = tempo;
                    }

                    addtextbox(panel2, l, c);
                    affich_Mat(panel2);



                }
            }
            else if (radioButton3.Checked == true)
            {
               
                
                    for (int k = 0; k < Convert.ToInt16(textBox2.Text); k++)
                    {
                        int tempo = T[Convert.ToInt32(tbL.Text), k];
                        T[Convert.ToInt32(tbL.Text), k] = T[Convert.ToInt32(tbL2.Text), k];
                        T[Convert.ToInt32(tbL2.Text), k] = tempo;
                    }
                    for (int k = 0; k < Convert.ToInt16(textBox1.Text); k++)
                    {
                        int tempo = T[k, Convert.ToInt32(tbC.Text)];
                        T[k, Convert.ToInt32(tbC.Text)] = T[k, Convert.ToInt32(tbC2.Text)];
                        T[k, Convert.ToInt32(tbC2.Text)] = tempo;
                    }
                    addtextbox(panel2, l, c);
                    affich_Mat(panel2);

                


            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}