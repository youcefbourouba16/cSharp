using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dgvEmployes.SetBounds(0, 224, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 300);
        }

        ClassInstitutBD cibd = new ClassInstitutBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            cibd.remplireGV(dgvEmployes, "select * from Employer");
        }



        private void button1_Click(object sender, EventArgs e) // btn ajouter
        {
            if (FormProcces.verifierTbInPanel(panel1))
            {
                MessageBox.Show("verifier les champs");
            }
            else if (textBoxPassword.Text != textBoxConpass.Text)
            {
                MessageBox.Show("verifier la confirmation mot de passe !.");
            }
            else
            {

                Model_Emp emp = new Model_Emp(textBoxNom.Text,
                    textBoxPrenom.Text,
                    dateTimePickerDN.Value,
                    textBoxEmail.Text,
                    textBoxUser.Text,
                    textBoxPassword.Text,
                    tb_struct.Text
                  );
                cibd.insererEmploye(emp);
                FormProcces.viderPanel(panel1);
                dateTimePickerDN.Value = DateTime.Now;
                cibd.remplireGV(dgvEmployes, "select * from Employer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormProcces.viderPanel(panel1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_Filtre.Text != "")
            {
                panel1.Visible = false;
                panel_Filter.Location = new Point(20, 20);
                dgvEmployes.SetBounds(0, 120, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            }
            else {
                panel1.Visible = true;
                panel_Filter.Location = new Point(593, 90);
                dgvEmployes.SetBounds(0, 224, Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            }
            
            String s = $"select *" +
                $"from Employer " +
                $"where IdEmp like '%{tb_Filtre.Text}%' or nomEmp like '%{tb_Filtre.Text}%'";
            cibd.remplireGV(dgvEmployes, s);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cibd.Edit_emp();
                MessageBox.Show("le tableau a été mis à jour");
            }
            catch (Exception f)
            {

                MessageBox.Show(f.ToString());
            }
            finally
            {
                cibd.remplireGV(dgvEmployes, "select * from Employer");
            }
           

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvEmployes.SelectedRows[0];

                    // Get the value of the first cell in the selected row
                    String ID = selectedRow.Cells[0].Value.ToString();
                    cibd.Delete_Emp(ID);
                    MessageBox.Show("L'employeur a été supprimé avec succès"+ ID);
                    cibd.remplireGV(dgvEmployes, "select * from Employer");
                }
                catch (Exception o)
                {

                    MessageBox.Show(o.ToString());
                }
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
