using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_s2Csharp.Data
{
    public class SqlConnector
    {
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        SqlCommand com = new SqlCommand();
        SqlDataAdapter Sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = @"Data Source=DESKTOP-KNG9Q9T\SQLEXPRESS;Initial Catalog=ITEEM;Persist Security Info=True;User ID=root;Password=06122099youcef;TrustServerCertificate=True";

                con.Open();
                MessageBox.Show("connected");
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
        public void insertEtudiant(Etudiant et)
        {
            //Connecter();
            //com.CommandText = req;
            //com.ExecuteNonQuery();
            //Deconnecter();
            Connecter();
            string s = $"insert into Etudiant (mat,nom,prenom,sexe,dn) VALUES(" +
                $"{et.Mat}," +
                $"'{et.Nom}'," +
                $"'{et.Prenom}'," +
                $"'{et.Sexe}'," +
                $"'{et.Dn.Year}')";
            MessageBox.Show(s);
            
                //cmd.Parameters.AddWithValue("@mat", et.Mat);
                //cmd.Parameters.AddWithValue("@nom", et.Nom);
                //cmd.Parameters.AddWithValue("@prenom", et.Prenom);
                //cmd.Parameters.AddWithValue("@sexe", et.Sexe);
                //cmd.Parameters.AddWithValue("@dn", et.Dn);
                
                    com.CommandText = s;
                    com.ExecuteNonQuery();

                
                //catch (Exception e)
                //{

                //    MessageBox.Show(e.ToString(), "UNABLE To connect to the Server", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                //}

            
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
        /// <summary>
        /// true for empty tb
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
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
