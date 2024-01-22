using exam_s2Csharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace exam_s2Csharp.Data
{
    public  class DataAcess
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
                    con.ConnectionString = @"Data Source=DESKTOP-KNG9Q9T\SQLEXPRESS;Initial Catalog=Bank System;Persist Security Info=True;User ID=root;Password=06122099youcef;TrustServerCertificate=True";

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
        public Boolean checkUser_existance(User_info user )
        {
            Connecter();
            bool exist = true;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM user_info WHERE username=@username AND password=@password", con))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                try
                {
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows) exist = false;

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString(), "UNABLE To connect to the Server", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    exist = false;

                }

            }
            Deconnecter();
            return exist;
        }

    }
}
