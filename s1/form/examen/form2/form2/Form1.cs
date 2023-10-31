namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lbR.Text = "";
            label6.Visible = true;
            tbX2.Visible = true;
            if (tbA.Text == "" || tbB.Text == "" || tbC.Text == "")
            {
                MessageBox.Show("donner tout les valeur");
            }
            else
            {
                int A = Convert.ToInt16(tbA.Text);
                int B = Convert.ToInt16(tbB.Text);
                int C = Convert.ToInt16(tbC.Text);

                if (A == 0 && B == 0)
                {
                    MessageBox.Show("A et B doit etre diffrent a 0");


                }
                else if (A == 0)
                {
                    tbX1.Text = Convert.ToString((double)-C / (double)B);
                    label6.Visible = false;
                    tbX2.Visible = false;

                }
                else
                {
                    double delta = Math.Pow(B, 2) - 4 * A * C;

                    if (delta > 0)
                    {
                        tbX1.Text = Convert.ToString(-B - Math.Pow(delta, 0.5) / 2 * A);
                        tbX2.Text = Convert.ToString(-B + Math.Pow(delta, 0.5) / 2 * A);

                    }
                    else if (delta == 0)
                    {
                        tbX1.Text = Convert.ToString((-B) / 2 * A);

                    }
                    else lbR.Text = "pas de solution";
                }
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbR.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";
            tbX1.Text = "";
            tbX2.Text = "";
            lbR.Text = "";
            tbX2.Visible = true;
            label6.Visible = true;

        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }

}