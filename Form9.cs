using Guna.UI2.WinForms;
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

namespace CODSE233F_023_GUI
{
    public partial class Form9 : Form
    {
        Function fn = new Function();
        string query;

        public Form9()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "insert into item(itemname,category,price)values('" + name.Text + "','" + cmbcategory.Text + "','" + price.Text + "')";
            fn.setData(query);
            clearall();
            loadData();
        }
        public void clearall()
        {
            name.Clear();
            cmbcategory.SelectedItem = -1;
            price.Clear();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadData() //method using table data
        {
            query = "SELECT * FROM item";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string cs = "data source=THINKBOOK;database=Candy;Integrated security= True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "Select * from item";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.guna2DataGridView1.DataSource = ds.Tables[0];

            con.Close();
            loadData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) //search
        {
            query = "SELECT * FROM item WHERE itemname LIKE '" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }

}
