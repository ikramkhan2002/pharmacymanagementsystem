
namespace pharmacymanagementsystem
{
    partial class medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicine));
            this.label1 = new System.Windows.Forms.Label();
            this.medname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellpricetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.qtytb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.medgridview = new Guna.UI.WinForms.GunaDataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.dlt = new System.Windows.Forms.Button();
            this.compcb = new Guna.UI.WinForms.GunaComboBox();
            this.exptb = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.medgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDICINE STOCK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // medname
            // 
            this.medname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.medname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medname.ForeColor = System.Drawing.Color.MediumBlue;
            this.medname.HintForeColor = System.Drawing.Color.MediumBlue;
            this.medname.HintText = "MEDICINE NAME";
            this.medname.isPassword = false;
            this.medname.LineFocusedColor = System.Drawing.Color.Blue;
            this.medname.LineIdleColor = System.Drawing.Color.Gray;
            this.medname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.medname.LineThickness = 3;
            this.medname.Location = new System.Drawing.Point(16, 60);
            this.medname.Margin = new System.Windows.Forms.Padding(4);
            this.medname.Name = "medname";
            this.medname.Size = new System.Drawing.Size(184, 33);
            this.medname.TabIndex = 2;
            this.medname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.medname.OnValueChanged += new System.EventHandler(this.medname_OnValueChanged);
            this.medname.Enter += new System.EventHandler(this.medname_Enter);
            // 
            // bprice
            // 
            this.bprice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprice.ForeColor = System.Drawing.Color.MediumBlue;
            this.bprice.HintForeColor = System.Drawing.Color.MediumBlue;
            this.bprice.HintText = "BUY PRICE";
            this.bprice.isPassword = false;
            this.bprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.bprice.LineIdleColor = System.Drawing.Color.Gray;
            this.bprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bprice.LineThickness = 3;
            this.bprice.Location = new System.Drawing.Point(213, 60);
            this.bprice.Margin = new System.Windows.Forms.Padding(4);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(160, 33);
            this.bprice.TabIndex = 3;
            this.bprice.Text = "BUYING PRICE";
            this.bprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bprice.Enter += new System.EventHandler(this.bprice_Enter);
            // 
            // sellpricetb
            // 
            this.sellpricetb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sellpricetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellpricetb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellpricetb.ForeColor = System.Drawing.Color.MediumBlue;
            this.sellpricetb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.sellpricetb.HintText = "SELL PRICE";
            this.sellpricetb.isPassword = false;
            this.sellpricetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.sellpricetb.LineIdleColor = System.Drawing.Color.Gray;
            this.sellpricetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sellpricetb.LineThickness = 3;
            this.sellpricetb.Location = new System.Drawing.Point(213, 120);
            this.sellpricetb.Margin = new System.Windows.Forms.Padding(4);
            this.sellpricetb.Name = "sellpricetb";
            this.sellpricetb.Size = new System.Drawing.Size(160, 33);
            this.sellpricetb.TabIndex = 4;
            this.sellpricetb.Text = "SELLING PRICE";
            this.sellpricetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellpricetb.Enter += new System.EventHandler(this.sellpricetb_Enter);
            // 
            // qtytb
            // 
            this.qtytb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qtytb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytb.ForeColor = System.Drawing.Color.MediumBlue;
            this.qtytb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.qtytb.HintText = "QUANTITY";
            this.qtytb.isPassword = false;
            this.qtytb.LineFocusedColor = System.Drawing.Color.Blue;
            this.qtytb.LineIdleColor = System.Drawing.Color.Gray;
            this.qtytb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.qtytb.LineThickness = 3;
            this.qtytb.Location = new System.Drawing.Point(213, 183);
            this.qtytb.Margin = new System.Windows.Forms.Padding(4);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(160, 33);
            this.qtytb.TabIndex = 5;
            this.qtytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qtytb.Enter += new System.EventHandler(this.qtytb_Enter);
            // 
            // medgridview
            // 
            this.medgridview.AllowUserToResizeColumns = false;
            this.medgridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.medgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medgridview.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.medgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medgridview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.medgridview.EnableHeadersVisualStyles = false;
            this.medgridview.GridColor = System.Drawing.Color.Red;
            this.medgridview.Location = new System.Drawing.Point(410, 12);
            this.medgridview.Name = "medgridview";
            this.medgridview.RowHeadersVisible = false;
            this.medgridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medgridview.Size = new System.Drawing.Size(553, 511);
            this.medgridview.TabIndex = 8;
            this.medgridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.medgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.medgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medgridview.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.medgridview.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.medgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.medgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medgridview.ThemeStyle.HeaderStyle.Height = 30;
            this.medgridview.ThemeStyle.ReadOnly = false;
            this.medgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.medgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.medgridview.ThemeStyle.RowsStyle.Height = 22;
            this.medgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.medgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.medgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Goldenrod;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(22, 325);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 38);
            this.add.TabIndex = 9;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Goldenrod;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(124, 325);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 38);
            this.update.TabIndex = 10;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Goldenrod;
            this.dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt.ForeColor = System.Drawing.Color.Black;
            this.dlt.Location = new System.Drawing.Point(233, 325);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(96, 38);
            this.dlt.TabIndex = 11;
            this.dlt.Text = "DELETE";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
            // 
            // compcb
            // 
            this.compcb.BackColor = System.Drawing.Color.Transparent;
            this.compcb.BaseColor = System.Drawing.Color.White;
            this.compcb.BorderColor = System.Drawing.Color.Silver;
            this.compcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.compcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compcb.FocusedColor = System.Drawing.Color.Empty;
            this.compcb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.compcb.ForeColor = System.Drawing.Color.Black;
            this.compcb.FormattingEnabled = true;
            this.compcb.Location = new System.Drawing.Point(16, 183);
            this.compcb.Name = "compcb";
            this.compcb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.compcb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.compcb.Size = new System.Drawing.Size(184, 26);
            this.compcb.TabIndex = 13;
            this.compcb.SelectedIndexChanged += new System.EventHandler(this.compcb_SelectedIndexChanged);
            // 
            // exptb
            // 
            this.exptb.BackColor = System.Drawing.Color.Crimson;
            this.exptb.BaseColor = System.Drawing.SystemColors.ControlText;
            this.exptb.BorderColor = System.Drawing.Color.Silver;
            this.exptb.CustomFormat = null;
            this.exptb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.exptb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.exptb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exptb.ForeColor = System.Drawing.Color.Chocolate;
            this.exptb.Location = new System.Drawing.Point(16, 123);
            this.exptb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.exptb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.exptb.Name = "exptb";
            this.exptb.OnHoverBaseColor = System.Drawing.Color.White;
            this.exptb.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.exptb.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.exptb.OnPressedColor = System.Drawing.Color.Black;
            this.exptb.Size = new System.Drawing.Size(184, 30);
            this.exptb.TabIndex = 12;
            this.exptb.Text = "Monday, March 27, 2023";
            this.exptb.Value = new System.DateTime(2023, 3, 27, 2, 50, 3, 805);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(136, 381);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 24;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.compcb);
            this.Controls.Add(this.exptb);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.medgridview);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.sellpricetb);
            this.Controls.Add(this.bprice);
            this.Controls.Add(this.medname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicine";
            this.Load += new System.EventHandler(this.medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox medname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellpricetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox qtytb;
        private Guna.UI.WinForms.GunaDataGridView medgridview;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button dlt;
        private Guna.UI.WinForms.GunaComboBox compcb;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaDateTimePicker exptb;
    }
}