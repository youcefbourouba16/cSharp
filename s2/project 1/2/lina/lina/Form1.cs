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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// value the app start with 
            lb_oldSold.Text = "0.00";
            lb_NewSold.Text = "0.00";
        }
        // global variable location outside (varibale that stay in the app untill the app get closed ) 
        decimal oldSold=0, newSold=0;// start with 0 cuz we just opened the app
        // decimal for money usuly you can use double tho


        private void btn_action_Click(object sender, EventArgs e)
        {
            ///-1 check if the radio button is selected first 
            /// !   this refered to NOT 
            /// if radio button not checked rb_insert.Checked==false or !rb_insert.Checked
            if (!rb_insert.Checked && !rb_widthraw.Checked) //rb_insert.Checked==false
                                                            //&& rb_widthraw.Checked==false
            {
                MessageBox.Show("you have to select the opperation first !!!");
                return; ///basecally stop back to main program without doing anthing 
            }

            /////-2 check if the text box isnt empty
            if (tb_money.Text=="")
            {
                MessageBox.Show("you have to put the money amount you want to insert or widthraw !!!");
                return; ///basecally stop back to main program without doing anthing 
            }

            ///// -3 check if text box is a number not a letter
            if (!decimal.TryParse(tb_money.Text, out _))//// check if that text is decimal or not
                                                       //// if yes return true if not return false
            {
                /// we use ! so if not decimal (sma lettre hna )
                MessageBox.Show("you have to enter a valid money amount !!!");
                return; ///basecally stop back to main program without doing anthing 

            }

            /// now we start the logic part
            lb_oldSold.Text = newSold.ToString(); //// convert any type of values into string

            Decimal tempMoney = Convert.ToDecimal(tb_money.Text); /// convert String to Decimal (can be applied with evey digital type)
            if (rb_widthraw.Checked) /// radio button is selected 
            {
                if (newSold==0)
                {
                    MessageBox.Show("you cant widthraw cuz you're broke !!!",
                        "brokey",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    return; ///basecally stop back to main program without doing anthing 
                }
                else
                {
                    oldSold = newSold; //// make the old sold new value
                    if (tempMoney> oldSold)
                    {
                        MessageBox.Show("you can widthraw "+tempMoney+" cuz you have just"+oldSold+" !!!");
                        return; ///basecally stop back to main program without doing anthing 
                    }
                    newSold = oldSold - tempMoney;

                }
            }
            else
            {
                newSold = oldSold + tempMoney;
            }

            //// now finaly we display new sold with message that the opperation completed succesfully
            MessageBox.Show("the operation completed successfully ");
            lb_NewSold.Text=newSold.ToString();


        }
    }
}
