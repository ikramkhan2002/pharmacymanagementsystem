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

namespace pharmacymanagementsystem
{
    public partial class reportsform : Form
    {
        private UserControl1 userControl1;
        private UserControl3 userControl3;
        private SqlConnection conn;
        public reportsform()
        {

            InitializeComponent();

            userControl1 = new UserControl1();
            userControl3 = new UserControl3();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");

            // Set the location of the user control to the right of the panel
            userControl1.Location = new Point(panel1.Width, 0);
            userControl3.Location = new Point(panel1.Width, 0);

            // Set the size of the user controls
            userControl1.Size = new Size(ClientSize.Width - panel1.Width, ClientSize.Height);
            userControl3.Size = new Size(ClientSize.Width - panel1.Width, ClientSize.Height);

            // Set the Dock property of the user controls to Fill
           // userControl1.Dock = DockStyle.Fill;
           // userControl3.Dock = DockStyle.Fill;

            // Add the user controls to the form's Controls collection
            this.Controls.Add(userControl1);
            this.Controls.Add(userControl3);

            // Hide the user controls initially
            userControl1.Hide();
            userControl3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            userControl3.Hide();
            userControl1.Visible = true;

            // Set the location of the user control to the right of the panel
            userControl1.Location = new Point(panel1.Width, 0);

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
                userControl1.crystalReportViewer1.ReportSource = report;
                userControl1.crystalReportViewer1.Refresh();
            }

            // Close the database connection
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            if (!this.Controls.Contains(userControl3))
            {
                this.Controls.Add(userControl3);
            }
            // userControl3.Show();
            pictureBox2.Hide();
            userControl1.Hide();
            userControl3.Visible = true;

            // Set the location of the user control to the right of the panel
            userControl3.Location = new Point(panel1.Width, 0);
            // Open the database connection
            conn.Open();

            // Create a SQL command to select data from the "medicine" table
            SqlCommand cmd = new SqlCommand("SELECT * FROM medicine ", conn);

            // Create a data adapter to fill the dataset
            using (SqlDataAdapter sd = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                sd.Fill(ds, "medicine");

                // Create an instance of the Crystal Report
                CrystalReport4 report = new CrystalReport4();

                // Set the dataset as the report's data source
                report.SetDataSource(ds);

                // Set the report as the ReportSource for the Crystal Report Viewer in the user control
                userControl3.crystalReportViewer1.ReportSource = report;
                userControl3.crystalReportViewer1.Refresh();
            }

            // Close the database connection
            conn.Close();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to exit application", "button4"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void reportsform_Load(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }
    } 
}
