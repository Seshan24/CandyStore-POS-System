using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CODSE233F_023_GUI
{
    public partial class Form10 : Form
    {
        Function fn = new Function();
        String query;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e) //load method call
        {
            loadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "update item set itemname = '" + guna2TextBox3.Text + "', category = '" + cmbcategory.Text + "', price = '" + guna2TextBox2.Text + "' WHERE iid = " + id + "";
            fn.setData(query);
            loadData();//load data method call
            clearall();//clearall method call

        }
        public void loadData() //method using table data
        {
            query = "SELECT * FROM item";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) //search method
        {
            query = "SELECT * FROM item WHERE itemname LIKE '" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click method
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            cmbcategory.Text = category;
            guna2TextBox3.Text = name;
            guna2TextBox2.Text = price.ToString();
        }
        public void clearall() //create clearall method
        {
            guna2TextBox3.Clear();
            cmbcategory.SelectedItem = -1;
            guna2TextBox2.Clear();
        }
    }
}
