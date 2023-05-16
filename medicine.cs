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
    public partial class medicine : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");
        public void populate() {
            Conn.Open();
            string myquery = "select * from medicine ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(myquery, Conn);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(dataadapter);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            medgridview.ReadOnly = true;
            medgridview.DataSource = ds.Tables[0];
            Conn.Close();
        }
        public medicine()
        {
            InitializeComponent();
        }
        public void poulateCb()
        {
            /*   String sql = "select * from company";
              SqlCommand cmd = new SqlCommand(sql, Conn);
              SqlDataReader rdr;
              try
              {
                  Conn.Open();
                  DataTable dt = new DataTable();
                  dt.Columns.Add("cmpname", typeof(string));
                  rdr = cmd.ExecuteReader();
                  compcb.ValueMember = "cmpname";
                  compcb.DataSource = dt;
                  dt.Load(rdr);
                  Conn.Close();
              }
              catch
              {

              } */
            Conn.Open();
            SqlCommand cmd = new SqlCommand("select cmpname from company", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmpname", typeof(string));
            dt.Load(rdr);
            compcb.ValueMember = "cmpname";
            compcb.DataSource = dt;
            //compcb.DisplayMember = "company";
            Conn.Close();
        }




            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void medicine_Load(object sender, EventArgs e)
        {
            populate();
            poulateCb();
            this.ActiveControl = add;
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medname.Text = medgridview.SelectedRows[0].Cells[0].Value.ToString();
            bprice.Text = medgridview.SelectedRows[0].Cells[1].Value.ToString();
            sellpricetb.Text= medgridview.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text= medgridview.SelectedRows[0].Cells[3].Value.ToString();
            exptb.Text= medgridview.SelectedRows[0].Cells[4].Value.ToString();
            compcb.SelectedValue= medgridview.SelectedRows[0].Cells[5].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medname.Text == "" || sellpricetb.Text == "" || bprice.Text == "" || qtytb.Text == "" || compcb.SelectedItem== null)
            {
                MessageBox.Show("Missing some Information");
            }
            else {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into medicine values('" + medname.Text + "','" + bprice.Text + "','" + sellpricetb.Text + "','" + qtytb.Text + "','" + exptb.Text + "','" + compcb.SelectedValue.ToString() + "') ", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("medicine added");
                Conn.Close();
                populate(); }
        }

        private void update_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String myquery = "update medicine SET  buyprice = " + bprice.Text+",sellprice ="+sellpricetb.Text+",qty="+qtytb.Text+ ",exp='" + exptb.Text + "',company='" + compcb.SelectedValue.ToString() + "'WHERE medname='" + medname.Text+"'";
            SqlCommand cmd = new SqlCommand(myquery, Conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("medicine successfully updated");
            Conn.Close();
            populate();

        }

        private void dlt_Click(object sender, EventArgs e)
        {
            if (medname.Text == "")
            {
                MessageBox.Show("nothing to delete");
            }
            else
            {
                Conn.Open();
                string query = "delete from medicine where medname = '" + medname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("medicine successfully deleted");
                Conn.Close();
                populate();
            }
        }

        private void compcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qtytb_OnValueChanged(object sender, EventArgs e)
        {
            qtytb.Text = "";
        }

        private void medname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void medname_Enter(object sender, EventArgs e)
        {
            medname.Text = "";
        }

        private void bprice_Enter(object sender, EventArgs e)
        {
            bprice.Text = "";
        }

        private void sellpricetb_Enter(object sender, EventArgs e)
        {
            sellpricetb.Text = "";

        }

        private void qtytb_Enter(object sender, EventArgs e)
        {
            qtytb.Text = "";
        }
    }
}
