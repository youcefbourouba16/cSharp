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
    public partial class main : Form
    {
        UserAndPassword LogedInUser;
        public main(UserAndPassword q)
        {
            LogedInUser= q;
            InitializeComponent();
        }

        private void bnt_backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login(LogedInUser, false);
            frm.ShowDialog();

        }

        private void main_Load(object sender, EventArgs e)
        {
            string gender;
            if (LogedInUser.gender == 0)
            {
                gender = "M.";
            }
            else gender = "Mme";
            lb_welcome.Text = "Welcome  "+gender+" :" + LogedInUser.Username;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
