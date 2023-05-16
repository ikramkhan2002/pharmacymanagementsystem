using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace pharmacymanagementsystem
{
    public partial class login : Form
       
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            /*if (username.Text == "admin" && password.Text == "admin")
             {
                 home hm = new home();
                 hm.Show();
                 this.Hide();

             }
             else
             {
                 MessageBox.Show("Incorrect user name or password");*/
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from emp_tbl where empname = '"+username.Text+"' and empPass = '"+password.Text+"' ",conn  );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password");
            }
            conn.Close();
            
        }

        private void username_Enter(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = "";
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to exit application", "gunaImageButton1"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*  Form1 frm = new Form1();
              UserControl1 fm = new UserControl1();
              this.Hide();
              fm.Show();
              conn.Open();
              SqlCommand cmd = new SqlCommand("select * from medicine", conn);
              SqlDataAdapter sd = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              sd.Fill(ds, "medicine");
              CrystalReport3 cr3 = new CrystalReport3();
              cr3.SetDataSource(ds);
              fm.crystalReportViewer1.ReportSource = cr3;
              fm.crystalReportViewer1.Refresh();
              conn.Close();*/
            // Create an instance of the user control
            UserControl1 userControl = new UserControl1();

            // Open the database connection


            conn.Open();

            // Create a SQL command to select data from the "medicine" table
            SqlCommand cmd = new SqlCommand("SELECT * FROM medicine WHERE TRY_CONVERT(date, SUBSTRING(exp, CHARINDEX(',', exp) + 2, LEN(exp)), 107) < CONVERT(date, GETDATE())", conn);

            // Create a data adapter to fill the dataset
            using (SqlDataAdapter sd = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                sd.Fill(ds, "medicine");

                // Create an instance of the Crystal Report
                CrystalReport3 report = new CrystalReport3();

                // Set the dataset as the report's data source
                report.SetDataSource(ds);

                // Set the report as the ReportSource for the Crystal Report Viewer in the user control
                userControl.crystalReportViewer1.ReportSource = report;
                userControl.crystalReportViewer1.Refresh();

                // Show the main form with the user control
                userControl.Dock = DockStyle.Fill;
                Form form = new Form();
                form.Controls.Add(userControl);
                form.ShowDialog();
            }

            conn.Close();

        }
    }
}
