using System;

namespace tableux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] voiture = { "BMW", "SKODA", "FORD" };
            voiture[2] = "VOLVO";
            int cpt = 0;

            TextBox tb;
            int m = Convert.ToInt16(textBox1.Text);

            for (int i = 1; i <=m; i++)
            {
                
                
                    tb = new TextBox();
                    tb.Text = "val" + i;
                    tb.Name = "val" + i;
                    tb.Location = new Point(10 + 50 * (m % 7), (m/7) *20*10);
                    tb.Size = new Size(50, 20);
                    m++;



                    panel1.Controls.Add(tb);
                
                 

            }


        }
    }
}