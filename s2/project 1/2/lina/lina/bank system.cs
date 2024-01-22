using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lina
{
    public partial class bank_system : Form
    {
        public bank_system()
        {
            InitializeComponent();
        }

        private void bank_system_Load(object sender, EventArgs e)
        {

        }

        decimal newsold = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (!rb_insert.Checked && !rb_widthraw.Checked) //rb_insert.Checked==false
                                                            //&& rb_widthraw.Checked==false
            {
                MessageBox.Show("you have to select the opperation first !!!");
                return; ///basecally stop back to main program without doing anthing 
            }
            /////-2 check if the text box isnt empty
            if (tb_money.Text == "")
            {
                MessageBox.Show("you have to put the money amount you want to insert or widthraw !!!");
                return; ///basecally stop back to main program without doing anthing 
            }
            if (!decimal.TryParse(tb_money.Text, out _))//// check if that text is decimal or not
                                                        //// if yes return true if not return false
            {
                /// we use ! so if not decimal (sma lettre hna )
                MessageBox.Show("you have to enter a valid money amount !!!");
                return; ///basecally stop back to main program without doing anthing 

            }

            if (rb_insert.Checked==true)
            {
                newsold = newsold + Convert.ToDecimal(tb_money.Text);
                lb_newsold.Text = newsold.ToString();
            }

        }
    }
}
