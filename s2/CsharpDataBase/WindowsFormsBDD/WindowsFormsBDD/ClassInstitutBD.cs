using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                con.ConnectionString = @"Data Source=DESKTOP-KNG9Q9T\SQLEXPRESS;Initial Catalog=Institut;Persist Security Info=True;User ID=root;Password=06122099youcef;TrustServerCertificate=True";

                con.Open();
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
        public void insererEmploye(string req) 
        {
            Connecter();
            com.CommandText = req;
            com.ExecuteNonQuery();
            Deconnecter();
        }
        public void viderPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        public bool verifierTbInPanel(Panel p)
        {
            Boolean b = false;
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "") { b = true; }
                }
                if (b) break;
            }
            return b;
        }

    }
}

