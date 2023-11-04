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
        List<UserAndPassword> ListUserClass = "textfile.txt".getFullpath().loadFile().convertToUserClass();
        List<string> ListUserString = "textfile.txt".getFullpath().loadFile();
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
        private void checkTbValue()
        {
            
        }
        private void saveFile_Click(object sender, EventArgs e)
        { 
           int gender = getGender(cb_male);
            int id = ListUserString.getLastId()+1;
           UserAndPassword temp = new UserAndPassword(id,tb_userName.Text, tb_password.Text, tb_nom.Text
                , tb_prenom.Text, tb_email.Text, gender);

            ListUserClass.Add(temp);
            ListUserClass.saveUserToTextfile("textfile.txt");
            Login frm = new Login(temp, true);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
