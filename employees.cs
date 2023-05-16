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
    public partial class employees : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");
        public void populate()
        {
            conn.Open();
            string myquery = "select * from emp_tbl ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(dataadapter);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            empGridview.ReadOnly = true;
            empGridview.DataSource = ds.Tables[0];
            conn.Close();
        }
        public employees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salary_tb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {
            populate();
            this.ActiveControl = add;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (empage_tb.Text == "" || empname_tb.Text == "" || salary_tb.Text == "" || empage_tb.Text == "" || pass_tb.Text == "" || gender_cb.SelectedItem == null) 
            {
                MessageBox.Show("Fill all the fields to add"); 
            }
          
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into emp_tbl values('"+empid_tb.Text+ "','" + empname_tb.Text + "','" + salary_tb.Text + "','" + empage_tb.Text + "','" +pass_tb.Text + "','"+gender_cb.SelectedItem.ToString()+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee data added successfully");
                conn.Close();
                populate();
            }
        }

        private void empage_tb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empid_tb.Text = empGridview.SelectedRows[0].Cells[0].Value.ToString();
            empname_tb.Text= empGridview.SelectedRows[0].Cells[1].Value.ToString();
            salary_tb.Text = empGridview.SelectedRows[0].Cells[2].Value.ToString();
            empage_tb.Text = empGridview.SelectedRows[0].Cells[3].Value.ToString();
            pass_tb.Text = empGridview.SelectedRows[0].Cells[4].Value.ToString();
            gender_cb.SelectedItem = empGridview.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            conn.Open();
            String myquery = "update emp_tbl SET empname= '" + empname_tb.Text + "',empsalary =" + salary_tb.Text + ",empAge=" + empage_tb.Text + ",empPass='" + pass_tb.Text + "',gender='" + gender_cb.SelectedItem.ToString() + "'WHERE empid='" + empid_tb.Text + "'";
            SqlCommand cmd = new SqlCommand(myquery, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("employee data successfully updated");
            conn.Close();
            populate();
        }

        private void dlt_Click(object sender, EventArgs e)
        {
            if (empname_tb.Text == "")
            {
                MessageBox.Show("nothing to delete");
            }
            else
            {
                conn.Open();
                string query = "delete from emp_tbl where empname = '" + empname_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("employee successfully deleted");
                conn.Close();
                populate();
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void empid_tb_Enter(object sender, EventArgs e)
        {
            empid_tb.Text = "";
        }

        private void empname_tb_Enter(object sender, EventArgs e)
        {
            empname_tb.Text = "";
        }

        private void salary_tb_Enter(object sender, EventArgs e)
        {
            salary_tb.Text = "";
        }

        private void pass_tb_Enter(object sender, EventArgs e)
        {
            pass_tb.Text = "";
        }

        private void empage_tb_Enter(object sender, EventArgs e)
        {
            empage_tb.Text = "";
        }
    }
}
