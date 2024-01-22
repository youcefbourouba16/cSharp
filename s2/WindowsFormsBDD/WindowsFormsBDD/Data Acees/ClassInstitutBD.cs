using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBDD
{
    internal class ClassInstitutBD
    {
        SqlConnection con = new SqlConnection();
        // Representation une connexion ouvere a une base de donnees
        DataTable dt = new DataTable();
        // Represente une table de donnees en memoire
        SqlCommand com = new SqlCommand();
        // represente des requetes SQL ou des procedures stockees
        SqlDataAdapter Sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.ConnectionString = @"Data Source=DESKTOP-KNG9Q9T\SQLEXPRESS;Initial Catalog=Institut;Persist Security Info=True;User ID=root;Password=06122099youcef;TrustServerCertificate=True";

                    con.Open();
                }
                catch (Exception)
                {

                    MessageBox.Show("Try to connect the dev team");
                }
                
            }
        }
        private void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void remplireGV(DataGridView dgv, string reqSgl)
        {
            dt.Clear();
            Connecter();
            com.Connection = con;
            com.CommandText = reqSgl;
            Sda.SelectCommand = com;
            Sda.Fill(dt);
            dgv.DataSource = dt;
            Deconnecter();

        }
        public void insererEmploye(Model_Emp emp) 
        {
            Connecter();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Employer VALUES (@Nom, @Prenom, @DateNaissance, @Email, @User, @Password, @Struct)", con))
            {
                cmd.Parameters.AddWithValue("@Nom", emp.NomEmp);
                cmd.Parameters.AddWithValue("@Prenom", emp.PrenomEmp);
                cmd.Parameters.AddWithValue("@DateNaissance", emp.DnEmp.Date);
                cmd.Parameters.AddWithValue("@Email", emp.EmailEmp);
                cmd.Parameters.AddWithValue("@User", emp.NomUlilis);
                cmd.Parameters.AddWithValue("@Password", emp.ModDePass);
                cmd.Parameters.AddWithValue("@Struct", emp.IdStr1);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    DialogResult result= MessageBox.Show("cette structure n'existe pas, souhaitez-vous ajouter une nouvelle structure","struct Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result== DialogResult.Yes)
                    {

                    }
                }
                
            }
            Deconnecter();
        }

        public void Edit_emp()
        {

            Connecter();
            // Use a SqlCommandBuilder to automatically generate the update command
            using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(Sda))
            {
                // Update the database with changes
                Sda.Update(dt);
            }
            Deconnecter();
        }
        public void Delete_Emp(string ID)
        {
            Connecter();
            String query = $"DELETE fROM Employer WHERE IdEmp = {ID}";
            MessageBox.Show(query);

            com.CommandText = query;

           com.ExecuteNonQuery();
            Deconnecter();
        }

    }
}

