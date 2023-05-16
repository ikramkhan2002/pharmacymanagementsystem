
namespace pharmacymanagementsystem
{
    partial class billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qty_lbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.billgridview = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.billgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILLING FORM";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // qty_lbl
            // 
            this.qty_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qty_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qty_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_lbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.qty_lbl.HintForeColor = System.Drawing.Color.MediumBlue;
            this.qty_lbl.HintText = "QUANTITY";
            this.qty_lbl.isPassword = false;
            this.qty_lbl.LineFocusedColor = System.Drawing.Color.Blue;
            this.qty_lbl.LineIdleColor = System.Drawing.Color.Gray;
            this.qty_lbl.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.qty_lbl.LineThickness = 3;
            this.qty_lbl.Location = new System.Drawing.Point(29, 124);
            this.qty_lbl.Margin = new System.Windows.Forms.Padding(4);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(133, 33);
            this.qty_lbl.TabIndex = 3;
            this.qty_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qty_lbl.OnValueChanged += new System.EventHandler(this.medname_OnValueChanged);
            this.qty_lbl.Enter += new System.EventHandler(this.qty_lbl_Enter);
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_lbl.Location = new System.Drawing.Point(30, 86);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(98, 17);
            this.stock_lbl.TabIndex = 4;
            this.stock_lbl.Text = "AvailableStock";
            this.stock_lbl.Visible = false;
            this.stock_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Goldenrod;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(45, 176);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(96, 38);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add to Bill";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // billgridview
            // 
            this.billgridview.AllowUserToResizeColumns = false;
            this.billgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.billgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billgridview.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.billgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billgridview.ColumnHeadersHeight = 30;
            this.billgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.medicinename,
            this.medqty,
            this.UnitPrice,
            this.totalprice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.billgridview.EnableHeadersVisualStyles = false;
            this.billgridview.GridColor = System.Drawing.Color.Red;
            this.billgridview.Location = new System.Drawing.Point(247, 9);
            this.billgridview.Name = "billgridview";
            this.billgridview.RowHeadersVisible = false;
            this.billgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billgridview.Size = new System.Drawing.Size(584, 402);
            this.billgridview.TabIndex = 11;
            this.billgridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.billgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.billgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.billgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.billgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.billgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.billgridview.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.billgridview.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.billgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.billgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billgridview.ThemeStyle.HeaderStyle.Height = 30;
            this.billgridview.ThemeStyle.ReadOnly = false;
            this.billgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.billgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.billgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billgridview.ThemeStyle.RowsStyle.Height = 22;
            this.billgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.billgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billgridview_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "MedId";
            this.id.Name = "id";
            // 
            // medicinename
            // 
            this.medicinename.HeaderText = "medname";
            this.medicinename.Name = "medicinename";
            // 
            // medqty
            // 
            this.medqty.HeaderText = "Quantity";
            this.medqty.Name = "medqty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "TotalPrice";
            this.totalprice.Name = "totalprice";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.totalamount.Location = new System.Drawing.Point(467, 426);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(192, 24);
            this.totalamount.TabIndex = 12;
            this.totalamount.Text = "TOTAL AMOUNT";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Goldenrod;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.Black;
            this.print.Location = new System.Drawing.Point(512, 453);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(96, 38);
            this.print.TabIndex = 13;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(64, 235);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 23;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.billgridview);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.stock_lbl);
            this.Controls.Add(this.qty_lbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox qty_lbl;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.Button addbtn;
        private Guna.UI.WinForms.GunaDataGridView billgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinename;
        private System.Windows.Forms.DataGridViewTextBoxColumn medqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Button print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}