using exam_s2Csharp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_s2Csharp
{
    public partial class frm_etudian : Form
    {
        public frm_etudian()
        {
            InitializeComponent();

        }
        SqlConnector sqlCon = new SqlConnector();
        private void frm_etudian_Load(object sender, EventArgs e)
        {

            load_comboBox(cb_sexe);
            sqlCon.remplireGV(dgv_etudiant, "select * from Etudiant");
        }

        
        private void load_comboBox(ComboBox cb)
        {
            cb.SelectedText = "M/F";
            cb.SelectedItem = null;
            cb.SelectedIndex = -1;
            string[] sexe = { "Male" , "female" };
            cb.Items.AddRange(sexe);
        }
        private void btn_Ajoute_Click(object sender, EventArgs e)
        {
            //// check if tb is empty
            if (tb_mat.Text=="")
            {
                logicB.messageboxAffich("Veuillez remplir La matricule ", "Mat");
                return;
            }
            if (tb_nom.Text == "")
            {
                logicB.messageboxAffich("Veuillez remplir Le nom ", "Nom");
                return;
            }
            if (tb_prenom.Text == "")
            {
                logicB.messageboxAffich("Veuillez remplir La matricule ", "Mat");
                return;
            }
            ////  check if Mat is integer
            if (!int.TryParse(tb_mat.Text, out _))
            {
                logicB.messageboxAffich("Matricule doit etre Entier seulment !!!","MAt");
                return;

            }
            //// check combo box if selected
            if (cb_sexe.SelectedIndex == -1)
            {
                logicB.messageboxAffich("Veuillez sélectionner le Sexe", "Sexe");
                return;
            }

            //// check if date naissance 
            DateTime dt = dtp_dn.Value;
            if (dt > DateTime.Today.AddYears(-16))
            {
                logicB.messageboxAffich("Etudiant doit etre 15 ans ou plus!!!", "MAt");
                return;
            }

            /// get gender
            char gender;
            if (cb_sexe.SelectedIndex == 1)
            {
                gender = 'M';
            } else gender = 'F';


            /// load etudiant model
            Etudiant etudiant = new Etudiant(Convert.ToInt16(tb_mat.Text),
                tb_nom.Text,
                tb_prenom.Text,
                gender,
                dt);
            sqlCon.insertEtudiant(etudiant);
            sqlCon.remplireGV(dgv_etudiant, "select * from Etudiant");






        }

        

        

        private void cb_sexe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
