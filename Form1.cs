using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CODSE233F_023_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //link to form3
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e) //login button
        {
            if (usename.Text=="Admin"&password.Text=="0000") //if username and pw is correct, form2 show
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else // if username or pw is incorrect messagebox show 
            {
                MessageBox.Show("Error: Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }
    }
}
