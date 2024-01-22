using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iteem
{

    public class SqlConnector
    {
        
       
         public static void connectSql(SqlConnection sqlConnection)
        {
            if (sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.ConnectionString = @"Data Source=DESKTOP-KNG9Q9T\SQLEXPRESS;Initial Catalog=Institut;Persist Security Info=True;User ID=root;Password=06122099youcef;TrustServerCertificate=True";
                sqlConnection.Open();
            }
        }
        public  static void DeconnectSql(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                
                sqlConnection.Close();
            }
        }
        
        public static  void fillGridView(DataGridView dataGridView,String query)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter sqlAdap = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Clear();
            connectSql(sqlConnection);
           com.Connection= sqlConnection;
            com.CommandText=query;
            sqlAdap.SelectCommand = com;
            sqlAdap.Fill(dt);
            dataGridView.DataSource=dt;
            DeconnectSql(sqlConnection);
            

        }
    }
}
