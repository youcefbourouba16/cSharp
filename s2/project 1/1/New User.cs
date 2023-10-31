using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class ADDuser : Form
    {
        List<UserAndPassword> List = "UserAndPassword".getFullpath().loadFile().convertToUserClass();
        public ADDuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private int getGender(RadioButton male)
        {
            if (male.Checked)
            {
                return 1;
            }
            else return 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int gender = getGender(cb_male);
            List<string> line = 
            UserAndPassword temp = new UserAndPassword(
                tb_userName.Text, tb_password.Text,tb_nom.Text
                ,tb_prenom.Text,tb_email.Text,gender
                );

            List.Add(temp);
            List.saveUserToTextfile("UserAndPassword");
            Login frm = new Login(temp,true);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
