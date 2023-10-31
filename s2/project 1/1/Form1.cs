using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Login : Form
    {
        
        List<UserAndPassword> List= "UserAndPassword".getFullpath().loadFile().convertToUserClass();
        /// <summary>
        /// Open login form///// name="a">User and Password get information
        /// ,  name="returnData">save data into List User and Password
        /// </summary>
        /// <param name="a">User and Password get information </param>
        /// <param name="returnData">save data into List User and Password  </param>
        public Login(UserAndPassword a, bool returnData)
        {
            if (returnData)
            {
                List.Add(a);
            }
           
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            Connect.Size = new Size(184, 54);

        }

        private void Connect_MouseLeave(object sender, EventArgs e)
        {

            Connect.Size = new Size(179, 48);
        }
        public void ConnectUser(List<UserAndPassword> List)
        {
            
            bool check = true;
            foreach (UserAndPassword i in List)
            {
                if (UserName.Text == i.Username && Password.Text == i.Password)
                {
                    main frm = new main(i);
                    this.Hide();
                    frm.ShowDialog();
                    check=false;
                }
                
            }
            if (check)
            {
                MessageBox.Show("Utilisateur ou mot de pass est incorect. !!!", "Error de Connection !.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectUser(List);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Password.PasswordChar = (char)0;
            else Password.PasswordChar = '*';
        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConnectUser(List);
            }
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
           
            
        }

        private void closee_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDuser frm = new ADDuser();
            frm.ShowDialog();
        }
    }
}
