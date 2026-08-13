using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODSE233F_023_GUI
{

    public partial class Form11 : Form
    {
        Function fn = new Function();
        String query;

        public Form11()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) //search
        {
            query = "select * from item where itemname like '" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        public void loaddata() //method using table data 
        {
            query = " select * from item";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete this Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete from item where iid=" + id + "";
                fn.setData(query);
                loaddata();
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
