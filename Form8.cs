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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            UpdateDateTimeLabels();
        }
        private void UpdateDateTimeLabels()
        {//display date & time
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }
    }
}
