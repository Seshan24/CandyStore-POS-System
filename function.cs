using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODSE233F_023_GUI
{
    internal class Function     //create class function
    {
        protected SqlConnection getconnection() //create sql connection
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=THINKBOOK;database=Candy;Integrated security= True";
            return con;
        }
        public DataSet getData(string query)   //create getdata query
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query)       //create setData queury
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data processed successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
