using DGVPrinterHelper;
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
    public partial class Form12 : Form
    {
        Function fn = new Function();
        String query;
        public Form12()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = guna2ComboBox1.Text;
            query = "select itemname from item where category ='" + category + "'";
            DataSet ds = fn.getData(query);
            //call the method to show items
            showItemList(query);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            String category = guna2ComboBox1.Text;
            query = "select itemname from item where category ='" + category + "'and itemname like '" + guna2TextBox1.Text + "%'";
            //call the method to show items
            showItemList(query);
        }
        private void showItemList(String query) //methord to show list of items

        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //add items to listbox
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the previous data
            guna2NumericUpDown1.ResetText();
            guna2TextBox3.Clear();
            //get text for select items
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            guna2TextBox2.Text = text;
            //get price of selected item
            query = "select price from item where itemname = '" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                guna2TextBox4.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(guna2NumericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(guna2TextBox4.Text);
            guna2TextBox3.Text = (quan * price).ToString();
        }
        int amount; // remove select cell items in datagrid view 
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());//get the amount of selected item
            }
            catch { }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index); //remove the selected item
            }
            catch
            { }
            total = total - amount;
            label9.Text = "Rs. " + total;
        }
        protected int n, total = 0;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter(); //print the bill
            printer.Title = "Candy Store Customer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));//set date and time
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip; //set bill format
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Amount: " + label9.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
            total = 0;
            label9.Text = "Rs. " + total;
            guna2DataGridView1.Rows.Clear();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text != "0" && guna2TextBox3.Text != "") //if total is empty cannot add to cart
            {
                //add items to cart and display in datagridview
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = guna2TextBox2.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = guna2TextBox4.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = guna2NumericUpDown1.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = guna2TextBox3.Text;
                //calculate the grand total amount
                total = total + int.Parse(guna2TextBox3.Text);
                label9.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("No item selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //display message if no item selected
            }
        }
    }
}
