﻿using System;
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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void btaffich_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int m = Convert.ToInt32(tb1.Text);
            TextBox tb;
            for (int i = 0; i < m; i++)
            {
                tb = new TextBox();
                tb.Text = "0";
                tb.Name = tb.Text;
                tb.Size = new Size(60, 40);
                int l = i / 7;
                int j = i % 7;         //محور تراتيب//  محور فواصل
                tb.Location = new Point(l * 70 + 5, j * 50 + 5);

                panel1.Controls.Add(tb);


            }
            Button btn = new Button();
            int l1 = m / 7;
            int j1 = m % 7;

            btn.Location = new Point(l1 * 70 + 5, j1 * 50 + 5);
            btn.Size = new Size(63, 26);
            btn.Text = "Somme";
            btn.Click += new System.EventHandler(btnSomme_Click);
            panel1.Controls.Add(btn);


        }

        double[] tab = new double[100];
        private void btnSomme_Click(object? sender, EventArgs e)
        {
            double som = 0;
            int i=0;
            // conrol= object 
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    tab[i] = Convert.ToDouble(c.Text); /// charger les element dans un vecteur
                    i++;
                }
            }
            foreach (double val in tab)/// ydi mn check elemnt valeur w yhatha f varaible Val
            {
                som += val;
            }
           
            MessageBox.Show("la somme est : " + som);
        }
        
    }
}
