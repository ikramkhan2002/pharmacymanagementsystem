using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacymanagementsystem
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            medicine med = new medicine();
            med.Show();
            this.Hide();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            billing bill = new billing();
            bill.Show();
            this.Hide();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            employees emp = new employees();
            emp.Show();
            this.Hide();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            company cmp = new company();
            cmp.Show();
            this.Hide();
        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportsform rep = new reportsform();
            rep.Show();this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            reportsform rf = new reportsform();
            rf.Show();
            this.Hide();
        }
    }
}
