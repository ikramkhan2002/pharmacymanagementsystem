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
    public partial class billing : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PHARMACY_MANAGEMENT\pharmacymanagementsystem\Database1.mdf;Integrated Security=True");
       public void poulateCb()
        {
            String sql = "select * from medicine";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader rdr;
            try
            {
                Conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("medname", typeof(string));
                rdr = cmd.ExecuteReader();
                comboBox1.ValueMember = "medname";
                comboBox1.DataSource = dt;
                dt.Load(rdr); 
                Conn.Close();
            }
            catch
            {

            }

        }
        public billing()
        {
            InitializeComponent();
        }
        int x,unitPrice;
        public void fetchQty()
        {
            Conn.Open();
            string mysql = "select * from medicine where medname ='" + comboBox1.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql,Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["qty"].ToString());
                unitPrice = Convert.ToInt32(dr["sellprice"].ToString());
                stock_lbl.Text = "Available Stock is "+dr["qty"].ToString();
                stock_lbl.Visible = true;
            }
            Conn.Close();

        }
        public void updatemedicine()
        {
            int newqty = x - Convert.ToInt32(qty_lbl.Text);
            Conn.Open();
            String myquery = "update medicine SET qty=" + newqty + "WHERE medname='" + comboBox1.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(myquery, Conn);
            cmd.ExecuteNonQuery();
          //  MessageBox.Show("medicine successfully updated");
            Conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void billing_Load(object sender, EventArgs e)
        {
            poulateCb();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }
        int gridtotal = 0;
        Bitmap bitmap;
        private void print_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        private void billgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void qty_lbl_Enter(object sender, EventArgs e)
        {
            qty_lbl.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int n = 0; 
            if (qty_lbl.Text == "" || Convert.ToInt32(qty_lbl.Text) > x)
            {
                MessageBox.Show("Stock is not enough to proceed");
            }
            else
            {
                int total = Convert.ToInt32(qty_lbl.Text) * unitPrice;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billgridview);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = qty_lbl.Text;
                newRow.Cells[3].Value = unitPrice;
                newRow.Cells[4].Value = unitPrice * Convert.ToInt32(qty_lbl.Text);
                billgridview.Rows.Add(newRow);
                gridtotal = gridtotal + total;
                totalamount.Text = "Rs" + gridtotal;
                updatemedicine();
            }
        }
    }
}
