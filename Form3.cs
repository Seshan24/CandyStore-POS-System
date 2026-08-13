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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateDateTimeLabels();
        }
        private void UpdateDateTimeLabels()
        {//display date & time
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }
    }
}
