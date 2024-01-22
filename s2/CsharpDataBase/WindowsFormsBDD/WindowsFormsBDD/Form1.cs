using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassInstitutBD cibd = new ClassInstitutBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            cibd.remplireGV(dgvEmployes, "select * from Employer");
        }

        

        private void button1_Click(object sender, EventArgs e) // btn ajouter
        {
           if( cibd.verifierTbInPanel(panel1) ){
                MessageBox.Show("verifier les champs");
            }else if (textBoxPassword.Text != textBoxConpass.Text)
            {
                MessageBox.Show("verifier la confirmation mot de passe !.");
            }
            else
            {
                // Appler la methode inserer
                // MessageBox.Show(dataTimePickerDN.Text);
                //dateTimePickerDN.Value.Date
                // dateTimePickerDN.CustomFormat = "dd/MM/yyyy;
                //" +dateTimePickerDN.Value.Date.ToString("dd/MM/yy") + "
                


                string req = "insert into Employer values ('" +textBoxNom.Text+ "','" +textBoxPrenom.Text+ "','" + dateTimePickerDN.Value.Date
                    + "','" + textBoxEmail.Text + "','"+textBoxUser.Text+ "','" +textBoxPassword.Text+ "','" +tb_struct.Text+"')";
                MessageBox.Show(req);
                cibd.insererEmploye(req);
                cibd.viderPanel(panel1 );
                dateTimePickerDN.Value = DateTime.Now;
                cibd.remplireGV(dgvEmployes, "select * from Employer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cibd.viderPanel(panel1 );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String s = $"select *" +
                $"from Employer " +
                $"where IdEmp like '%{tb_Filtre.Text}%' or nomEmp like '%{tb_Filtre.Text}%'";
            cibd.remplireGV(dgvEmployes,s);
        }
    }
}
