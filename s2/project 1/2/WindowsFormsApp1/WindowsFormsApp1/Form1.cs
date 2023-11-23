using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = "";
        private void button1_Click_1(Object sender, EventArgs e)
        {
            
                s += ((Button) sender).Text;
            MessageBox.Show(Add(5, 3).ToString());
            
            



                
            
        }
        public  int Add(int a, int b)
        {
            return a + b;
        }
    }
}
