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
    public partial class company : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");
        public void populate()
        {
            conn.Open();
            string myquery = "select * from company ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(dataadapter);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            cmpGridview.ReadOnly = true;
            cmpGridview.DataSource = ds.Tables[0];
            conn.Close();
        }
        public company()
        {
            InitializeComponent();
        }

        private void cmp_add_Click(object sender, EventArgs e)
        {
            if (cmpid_tb.Text == "" || cmpname_tb.Text == "" || address_tb.Text == "" || cmpphone_tb.Text == "")
            {
                MessageBox.Show("Fill all the fields to add");
            }

            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into company values('" + cmpid_tb.Text + "','" + cmpname_tb.Text + "','" + cmpphone_tb.Text + "','" + address_tb.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manufacturer data added successfully");
                conn.Close();
                populate();
            }
        }

        private void company_Load(object sender, EventArgs e)
        {
            populate();
            this.ActiveControl = cmp_add;
        }

        private void cmp_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            String myquery = "update company SET cmpname= '" + cmpname_tb.Text + "',cmpPhone ='" + cmpphone_tb.Text + "',cmpaddress='" + address_tb.Text +"' WHERE cmpid= '"+ cmpid_tb.Text +"'";
            SqlCommand cmd = new SqlCommand(myquery, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("manufacturer data successfully updated");
            conn.Close();
            populate();
        }

        private void cmpGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmpid_tb.Text = cmpGridview.SelectedRows[0].Cells[0].Value.ToString();
            cmpname_tb.Text = cmpGridview.SelectedRows[0].Cells[1].Value.ToString();
            cmpphone_tb.Text = cmpGridview.SelectedRows[0].Cells[2].Value.ToString();
            address_tb.Text = cmpGridview.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void cmp_dlt_Click(object sender, EventArgs e)
        {
            if (cmpname_tb.Text == "")
            {
                MessageBox.Show("nothing to delete");
            }
            else
            {
                conn.Open();
                string query = "delete from company where cmpname = '" + cmpname_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("manufacturer data successfully deleted");
                conn.Close();
                populate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void cmpid_tb_Enter(object sender, EventArgs e)
        {
            cmpid_tb.Text = "";
        }

        private void cmpname_tb_Enter(object sender, EventArgs e)
        {
            cmpname_tb.Text = "";
        }

        private void cmpphone_tb_Enter(object sender, EventArgs e)
        {
            cmpphone_tb.Text = "";
        }

        private void address_tb_Enter(object sender, EventArgs e)
        {
            address_tb.Text = "";
        }

        private void cmpid_tb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
