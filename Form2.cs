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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UpdateDateTimeLabels(); //display date & time
        }
        private void UpdateDateTimeLabels()
        {//display date & time
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e) //open form1
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e) //open form9
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e) //open form10
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e) //open form12
        {
            Form12 form = new Form12();
            form.Show();
            this.Hide();

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)   //open form11
        { 
            Form11 form = new Form11();
            form.Show();
            this.Hide();
        }
    }
}
