
namespace pharmacymanagementsystem
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.label1 = new System.Windows.Forms.Label();
            this.empid_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.salary_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gender_cb = new Guna.UI.WinForms.GunaComboBox();
            this.empage_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empname_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dlt = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.empGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.pass_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.empGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYESS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empid_tb
            // 
            this.empid_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.empid_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.empid_tb.HintForeColor = System.Drawing.Color.DarkOliveGreen;
            this.empid_tb.HintText = "employee id";
            this.empid_tb.isPassword = false;
            this.empid_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.empid_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.empid_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empid_tb.LineThickness = 3;
            this.empid_tb.Location = new System.Drawing.Point(16, 48);
            this.empid_tb.Margin = new System.Windows.Forms.Padding(4);
            this.empid_tb.Name = "empid_tb";
            this.empid_tb.Size = new System.Drawing.Size(184, 33);
            this.empid_tb.TabIndex = 3;
            this.empid_tb.Text = "EMPOLYEE ID";
            this.empid_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empid_tb.Enter += new System.EventHandler(this.empid_tb_Enter);
            // 
            // salary_tb
            // 
            this.salary_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salary_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.salary_tb.HintForeColor = System.Drawing.Color.DarkOliveGreen;
            this.salary_tb.HintText = "salary";
            this.salary_tb.isPassword = false;
            this.salary_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.salary_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.salary_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.salary_tb.LineThickness = 3;
            this.salary_tb.Location = new System.Drawing.Point(219, 48);
            this.salary_tb.Margin = new System.Windows.Forms.Padding(4);
            this.salary_tb.Name = "salary_tb";
            this.salary_tb.Size = new System.Drawing.Size(141, 33);
            this.salary_tb.TabIndex = 4;
            this.salary_tb.Text = "SALARY";
            this.salary_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salary_tb.OnValueChanged += new System.EventHandler(this.salary_tb_OnValueChanged);
            this.salary_tb.Enter += new System.EventHandler(this.salary_tb_Enter);
            // 
            // gender_cb
            // 
            this.gender_cb.BackColor = System.Drawing.Color.Transparent;
            this.gender_cb.BaseColor = System.Drawing.Color.White;
            this.gender_cb.BorderColor = System.Drawing.Color.Silver;
            this.gender_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cb.FocusedColor = System.Drawing.Color.Empty;
            this.gender_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender_cb.ForeColor = System.Drawing.Color.Black;
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gender_cb.Location = new System.Drawing.Point(219, 111);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gender_cb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gender_cb.Size = new System.Drawing.Size(141, 26);
            this.gender_cb.TabIndex = 14;
            this.gender_cb.Tag = "";
            // 
            // empage_tb
            // 
            this.empage_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.empage_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empage_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empage_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.empage_tb.HintForeColor = System.Drawing.Color.Blue;
            this.empage_tb.HintText = "AGE";
            this.empage_tb.isPassword = false;
            this.empage_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.empage_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.empage_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empage_tb.LineThickness = 3;
            this.empage_tb.Location = new System.Drawing.Point(219, 168);
            this.empage_tb.Margin = new System.Windows.Forms.Padding(4);
            this.empage_tb.Name = "empage_tb";
            this.empage_tb.Size = new System.Drawing.Size(141, 33);
            this.empage_tb.TabIndex = 15;
            this.empage_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empage_tb.OnValueChanged += new System.EventHandler(this.empage_tb_OnValueChanged);
            this.empage_tb.Enter += new System.EventHandler(this.empage_tb_Enter);
            // 
            // empname_tb
            // 
            this.empname_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.empname_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.empname_tb.HintForeColor = System.Drawing.Color.DarkOliveGreen;
            this.empname_tb.HintText = "NAME";
            this.empname_tb.isPassword = false;
            this.empname_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.empname_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.empname_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empname_tb.LineThickness = 3;
            this.empname_tb.Location = new System.Drawing.Point(16, 111);
            this.empname_tb.Margin = new System.Windows.Forms.Padding(4);
            this.empname_tb.Name = "empname_tb";
            this.empname_tb.Size = new System.Drawing.Size(184, 33);
            this.empname_tb.TabIndex = 16;
            this.empname_tb.Text = "EMPLOYEE NAME";
            this.empname_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empname_tb.Enter += new System.EventHandler(this.empname_tb_Enter);
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Goldenrod;
            this.dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt.ForeColor = System.Drawing.Color.Black;
            this.dlt.Location = new System.Drawing.Point(246, 312);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(96, 38);
            this.dlt.TabIndex = 19;
            this.dlt.Text = "DELETE";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Goldenrod;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(137, 312);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 38);
            this.update.TabIndex = 18;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Goldenrod;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(35, 312);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 38);
            this.add.TabIndex = 17;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // empGridview
            // 
            this.empGridview.AllowUserToResizeColumns = false;
            this.empGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.empGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empGridview.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.empGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empGridview.ColumnHeadersHeight = 30;
            this.empGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.empGridview.EnableHeadersVisualStyles = false;
            this.empGridview.GridColor = System.Drawing.Color.Red;
            this.empGridview.Location = new System.Drawing.Point(388, 9);
            this.empGridview.Name = "empGridview";
            this.empGridview.RowHeadersVisible = false;
            this.empGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.empGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empGridview.Size = new System.Drawing.Size(553, 511);
            this.empGridview.TabIndex = 20;
            this.empGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.empGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.empGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empGridview.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.empGridview.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.empGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.empGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.empGridview.ThemeStyle.HeaderStyle.Height = 30;
            this.empGridview.ThemeStyle.ReadOnly = false;
            this.empGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.empGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.empGridview.ThemeStyle.RowsStyle.Height = 22;
            this.empGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.empGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.empGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empGridview_CellContentClick);
            // 
            // pass_tb
            // 
            this.pass_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pass_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.ForeColor = System.Drawing.Color.MediumBlue;
            this.pass_tb.HintForeColor = System.Drawing.Color.DarkOliveGreen;
            this.pass_tb.HintText = "PASSWORD";
            this.pass_tb.isPassword = false;
            this.pass_tb.LineFocusedColor = System.Drawing.Color.Blue;
            this.pass_tb.LineIdleColor = System.Drawing.Color.Gray;
            this.pass_tb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pass_tb.LineThickness = 3;
            this.pass_tb.Location = new System.Drawing.Point(16, 168);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(4);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(184, 33);
            this.pass_tb.TabIndex = 21;
            this.pass_tb.Text = "password";
            this.pass_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass_tb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.pass_tb.Enter += new System.EventHandler(this.pass_tb_Enter);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(154, 365);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = global::pharmacymanagementsystem.Properties.Resources.backward__2_;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 24;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.empGridview);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.empname_tb);
            this.Controls.Add(this.empage_tb);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.salary_tb);
            this.Controls.Add(this.empid_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employees";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empid_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salary_tb;
        private Guna.UI.WinForms.GunaComboBox gender_cb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empage_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empname_tb;
        private System.Windows.Forms.Button dlt;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private Guna.UI.WinForms.GunaDataGridView empGridview;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass_tb;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}