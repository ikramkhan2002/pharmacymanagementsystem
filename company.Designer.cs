
namespace pharmacymanagementsystem
{
    partial class company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(company));
            this.cmpphone_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmpname_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmpid_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmpGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.cmp_dlt = new System.Windows.Forms.Button();
            this.cmp_update = new System.Windows.Forms.Button();
            this.cmp_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmpGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // cmpphone_tb
            // 
            this.cmpphone_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmpphone_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpphone_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpphone_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.cmpphone_tb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.cmpphone_tb.HintText = "CONTACT";
            this.cmpphone_tb.isPassword = false;
            this.cmpphone_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpphone_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.cmpphone_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpphone_tb.LineThickness = 3;
            this.cmpphone_tb.Location = new System.Drawing.Point(13, 154);
            this.cmpphone_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cmpphone_tb.Name = "cmpphone_tb";
            this.cmpphone_tb.Size = new System.Drawing.Size(184, 33);
            this.cmpphone_tb.TabIndex = 25;
            this.cmpphone_tb.Text = "Contact ";
            this.cmpphone_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpphone_tb.Enter += new System.EventHandler(this.cmpphone_tb_Enter);
            // 
            // cmpname_tb
            // 
            this.cmpname_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmpname_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpname_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpname_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.cmpname_tb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.cmpname_tb.HintText = "COMPANY NAME";
            this.cmpname_tb.isPassword = false;
            this.cmpname_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpname_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.cmpname_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpname_tb.LineThickness = 3;
            this.cmpname_tb.Location = new System.Drawing.Point(13, 101);
            this.cmpname_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cmpname_tb.Name = "cmpname_tb";
            this.cmpname_tb.Size = new System.Drawing.Size(184, 33);
            this.cmpname_tb.TabIndex = 24;
            this.cmpname_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpname_tb.Enter += new System.EventHandler(this.cmpname_tb_Enter);
            // 
            // address_tb
            // 
            this.address_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.address_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.address_tb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.address_tb.HintText = "ADDRESS";
            this.address_tb.isPassword = false;
            this.address_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.address_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.address_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.address_tb.LineThickness = 3;
            this.address_tb.Location = new System.Drawing.Point(13, 208);
            this.address_tb.Margin = new System.Windows.Forms.Padding(4);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(184, 33);
            this.address_tb.TabIndex = 23;
            this.address_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address_tb.Enter += new System.EventHandler(this.address_tb_Enter);
            // 
            // cmpid_tb
            // 
            this.cmpid_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmpid_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpid_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpid_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.cmpid_tb.HintForeColor = System.Drawing.Color.MediumBlue;
            this.cmpid_tb.HintText = "COMPANY ID";
            this.cmpid_tb.isPassword = false;
            this.cmpid_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpid_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.cmpid_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpid_tb.LineThickness = 3;
            this.cmpid_tb.Location = new System.Drawing.Point(13, 52);
            this.cmpid_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cmpid_tb.Name = "cmpid_tb";
            this.cmpid_tb.Size = new System.Drawing.Size(184, 33);
            this.cmpid_tb.TabIndex = 22;
            this.cmpid_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpid_tb.OnValueChanged += new System.EventHandler(this.cmpid_tb_OnValueChanged);
            this.cmpid_tb.Enter += new System.EventHandler(this.cmpid_tb_Enter);
            // 
            // cmpGridview
            // 
            this.cmpGridview.AllowUserToResizeColumns = false;
            this.cmpGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.cmpGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cmpGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmpGridview.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.cmpGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmpGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cmpGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmpGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cmpGridview.ColumnHeadersHeight = 30;
            this.cmpGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cmpGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.cmpGridview.EnableHeadersVisualStyles = false;
            this.cmpGridview.GridColor = System.Drawing.Color.Red;
            this.cmpGridview.Location = new System.Drawing.Point(364, 1);
            this.cmpGridview.Name = "cmpGridview";
            this.cmpGridview.RowHeadersVisible = false;
            this.cmpGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cmpGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmpGridview.Size = new System.Drawing.Size(535, 511);
            this.cmpGridview.TabIndex = 26;
            this.cmpGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.cmpGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.cmpGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cmpGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cmpGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cmpGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cmpGridview.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.cmpGridview.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.cmpGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmpGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cmpGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cmpGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmpGridview.ThemeStyle.HeaderStyle.Height = 30;
            this.cmpGridview.ThemeStyle.ReadOnly = false;
            this.cmpGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmpGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cmpGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmpGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cmpGridview.ThemeStyle.RowsStyle.Height = 22;
            this.cmpGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.cmpGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cmpGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmpGridview_CellContentClick);
            // 
            // cmp_dlt
            // 
            this.cmp_dlt.BackColor = System.Drawing.Color.Goldenrod;
            this.cmp_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmp_dlt.ForeColor = System.Drawing.Color.Black;
            this.cmp_dlt.Location = new System.Drawing.Point(221, 277);
            this.cmp_dlt.Name = "cmp_dlt";
            this.cmp_dlt.Size = new System.Drawing.Size(96, 38);
            this.cmp_dlt.TabIndex = 29;
            this.cmp_dlt.Text = "DELETE";
            this.cmp_dlt.UseVisualStyleBackColor = false;
            this.cmp_dlt.Click += new System.EventHandler(this.cmp_dlt_Click);
            // 
            // cmp_update
            // 
            this.cmp_update.BackColor = System.Drawing.Color.Goldenrod;
            this.cmp_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmp_update.ForeColor = System.Drawing.Color.Black;
            this.cmp_update.Location = new System.Drawing.Point(112, 277);
            this.cmp_update.Name = "cmp_update";
            this.cmp_update.Size = new System.Drawing.Size(96, 38);
            this.cmp_update.TabIndex = 28;
            this.cmp_update.Text = "UPDATE";
            this.cmp_update.UseVisualStyleBackColor = false;
            this.cmp_update.Click += new System.EventHandler(this.cmp_update_Click);
            // 
            // cmp_add
            // 
            this.cmp_add.BackColor = System.Drawing.Color.Goldenrod;
            this.cmp_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmp_add.ForeColor = System.Drawing.Color.Black;
            this.cmp_add.Location = new System.Drawing.Point(10, 277);
            this.cmp_add.Name = "cmp_add";
            this.cmp_add.Size = new System.Drawing.Size(96, 38);
            this.cmp_add.TabIndex = 27;
            this.cmp_add.Text = "ADD";
            this.cmp_add.UseVisualStyleBackColor = false;
            this.cmp_add.Click += new System.EventHandler(this.cmp_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "MANUFACTURER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(133, 331);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 31;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmp_dlt);
            this.Controls.Add(this.cmp_update);
            this.Controls.Add(this.cmp_add);
            this.Controls.Add(this.cmpGridview);
            this.Controls.Add(this.cmpphone_tb);
            this.Controls.Add(this.cmpname_tb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.cmpid_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "company";
            this.Load += new System.EventHandler(this.company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmpGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpphone_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpname_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpid_tb;
        private Guna.UI.WinForms.GunaDataGridView cmpGridview;
        private System.Windows.Forms.Button cmp_dlt;
        private System.Windows.Forms.Button cmp_update;
        private System.Windows.Forms.Button cmp_add;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}