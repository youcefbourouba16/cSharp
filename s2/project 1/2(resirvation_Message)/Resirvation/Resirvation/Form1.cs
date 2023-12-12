using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resirvation
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  global varibales
        /// </summary>
        public enum CI_Pass
        {
            CI,
            Passport

        }
        public Form1()
        {

            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 165;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_comboBox(cb_Ariver);
            load_comboBox(cb_depart);
            VisibleElemnts(false);
            numericUpDownSetings();
            
        }
        private void messageboxAffich(string message,string caption)
        {
            MessageBox.Show(message,caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        private void load_comboBox(ComboBox cb)
        {
            cb.SelectedText = "--- select";
            cb.SelectedItem = null;
            cb.SelectedIndex = -1;
            string[] wilaya = { "adrar", "Alger", "ghardaya", "chlef" };
            cb.Items.AddRange(wilaya);
        }
        private void changeLabel_CI_Password(CI_Pass s)
        {
            label5.Text="Num "+s.ToString()+" : ";
            label6.Text = "Date de delivrance " + s.ToString()+" :";
            label7.Text = "Date D'expiration " + s.ToString() + " :";
        }
        private void VisibleElemnts(bool b)
        {
            tb_num.Visible = b;
            label5.Visible = b;
            label5.Visible = b;
            label6.Visible = b;
            label7.Visible = b;
            dateTimePicker1.Visible = b;
            dateTimePicker2.Visible = b;
        }
       
        private void validation()
        {
            // TODO: add return in every if statment.
            if (cb_Ariver.SelectedItem == null || cb_depart.SelectedItem == null
                || cb_Ariver.Text == cb_depart.Text)
            {
                messageboxAffich(" Veuillez sélectionner la wilaya de départ et la destination.",
                "Ivalid Distination");
                return;
            }
            if (rb_aller_retour.Checked==rb_aller_simple.Checked)
            {
                messageboxAffich(" Veuillez sélectionner Aller retour ou bien aller sans retour",
                "Ivalid inputs");
                return;
            }
            if (rb_buis.Checked==rb_eco.Checked)
            {
                messageboxAffich(" Veuillez sélectionner voyage class",
                "Ivalid class ");
                return;
            }
            if (rb_ci.Checked==rb_pass.Checked)
            {
                messageboxAffich(" Veuillez sélectionner Passport ou bien cart ident",
                "Ivalid Indentite ");
                return;
            }

            if (tb_num.Text=="")
            {
                messageboxAffich(" Veuillez remplir le num identite",
                "Ivalid num Indentite ");
                return;
            }
            if (tb_name.Text == "")
            {
                messageboxAffich(" Veuillez remplir Votre Nom ",
                "Ivalid num Indentite ");
                return;
            }
            if (tb_prenom.Text == "")
            {
                messageboxAffich(" Veuillez remplir Votre Prenom  ",
                "Ivalid num Indentite ");
                return;
            }
            

        }
        private void numericUpDownSetings()
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 23;
            numericUpDown1.Increment = 3;
            numericUpDown1.ReadOnly = true;

        }
        private void btn_reserve_Click(object sender, EventArgs e)
        {
            
            validation();
            string A_R;
            bool passport;
            bool classe;
            if (rb_aller_retour.Checked) A_R = "Aller Retour";
            else A_R = "Aller Simple";

            if (rb_pass.Checked) passport = true;
            else passport = false;

            if (rb_buis.Checked) classe = true;
            else classe = false;
            ReservationData rd = new ReservationData(tb_name.Text,
                tb_prenom.Text,
                cb_depart.Text,
                cb_Ariver.Text,
                A_R,
                monthCalendar1.SelectionStart,
                monthCalendar1.SelectionEnd,
                passport,
                classe,
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                numericUpDown1.Value
                );

        }

        private void rb_pass_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel_CI_Password(CI_Pass.Passport);
            VisibleElemnts(true);
        }

        private void rb_ci_CheckedChanged(object sender, EventArgs e)
        {
            changeLabel_CI_Password(CI_Pass.CI);
            VisibleElemnts(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
            
        }
    }

}
