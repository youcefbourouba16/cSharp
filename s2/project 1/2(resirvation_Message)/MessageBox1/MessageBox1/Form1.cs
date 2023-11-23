using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("title", "message");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string input = "";
            ShowInputDialog(ref input);
        }

        private void bnt_confirmation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous ferme cette fenetre ?", 
                "fermer fenetre ",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            else MessageBox.Show("No");
        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            Size size = new Size(400, 80);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.Text = "Mot de Pass";

            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void ignore_retry_abord_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("voulez vous ferme cette fenetre ?",
                "fermer fenetre ",
                MessageBoxButtons.AbortRetryIgnore) == DialogResult.Retry)
            {
                this.Close();
            }
            else if (MessageBox.Show("voulez vous ferme cette fenetre ?",
                "fermer fenetre ",
                MessageBoxButtons.AbortRetryIgnore) == DialogResult.Abort)
            {
                MessageBox.Show("nothing happend");

            }
            else MessageBox.Show("ingored ;)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
