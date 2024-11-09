namespace Layout_QLTV.Child_UC.QLTacGia
{
    partial class UC_TacGiaSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblQLTacGiaSach = new Label();
            cboTruong = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cboMode = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label2 = new Label();
            grbDauSach = new GroupBox();
            dataGridView1 = new DataGridView();
            MaDauSach = new DataGridViewTextBoxColumn();
            TenDauSach = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            grbDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lblQLTacGiaSach
            // 
            lblQLTacGiaSach.AutoSize = true;
            lblQLTacGiaSach.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQLTacGiaSach.ForeColor = Color.FromArgb(2, 76, 170);
            lblQLTacGiaSach.Location = new Point(684, 46);
            lblQLTacGiaSach.Name = "lblQLTacGiaSach";
            lblQLTacGiaSach.Size = new Size(666, 74);
            lblQLTacGiaSach.TabIndex = 14;
            lblQLTacGiaSach.Text = "QUẢN LÝ TÁC GIẢ SÁCH";
            // 
            // cboTruong
            // 
            cboTruong.BackColor = Color.Transparent;
            cboTruong.CustomizableEdges = customizableEdges1;
            cboTruong.DrawMode = DrawMode.OwnerDrawFixed;
            cboTruong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTruong.FocusedColor = Color.FromArgb(94, 148, 255);
            cboTruong.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboTruong.Font = new Font("Segoe UI", 10F);
            cboTruong.ForeColor = Color.FromArgb(68, 88, 112);
            cboTruong.ItemHeight = 66;
            cboTruong.Items.AddRange(new object[] { "Đầu sách", "Tác giả" });
            cboTruong.Location = new Point(161, 201);
            cboTruong.Name = "cboTruong";
            cboTruong.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboTruong.Size = new Size(219, 72);
            cboTruong.TabIndex = 17;
            cboTruong.TextAlign = HorizontalAlignment.Center;
            cboTruong.SelectedIndexChanged += cboTruong_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.FocusedState.ForeColor = Color.Black;
            txtSearch.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.search;
            txtSearch.IconLeftOffset = new Point(20, 0);
            txtSearch.IconLeftSize = new Size(25, 25);
            txtSearch.IconRightSize = new Size(0, 0);
            txtSearch.Location = new Point(388, 201);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.DimGray;
            txtSearch.PlaceholderText = "Nhập để tìm kiếm tên đầu sách";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(1258, 74);
            txtSearch.TabIndex = 18;
            txtSearch.TextOffset = new Point(10, 0);
            // 
            // cboMode
            // 
            cboMode.BackColor = Color.Transparent;
            cboMode.CustomizableEdges = customizableEdges5;
            cboMode.DrawMode = DrawMode.OwnerDrawFixed;
            cboMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMode.FocusedColor = Color.FromArgb(94, 148, 255);
            cboMode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboMode.Font = new Font("Segoe UI", 10F);
            cboMode.ForeColor = Color.FromArgb(68, 88, 112);
            cboMode.ItemHeight = 66;
            cboMode.Items.AddRange(new object[] { "Xem", "Sửa" });
            cboMode.Location = new Point(1654, 201);
            cboMode.Name = "cboMode";
            cboMode.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboMode.Size = new Size(219, 72);
            cboMode.TabIndex = 19;
            cboMode.TextAlign = HorizontalAlignment.Center;
            cboMode.SelectedIndexChanged += cboMode_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold);
            label1.Location = new Point(164, 159);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 20;
            label1.Text = "Trường dữ liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold);
            label2.Location = new Point(1654, 159);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 21;
            label2.Text = "Chế độ";
            // 
            // grbDauSach
            // 
            grbDauSach.Controls.Add(dataGridView1);
            grbDauSach.Location = new Point(126, 347);
            grbDauSach.Name = "grbDauSach";
            grbDauSach.Size = new Size(612, 751);
            grbDauSach.TabIndex = 22;
            grbDauSach.TabStop = false;
            grbDauSach.Text = "Đầu sách";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaDauSach, TenDauSach });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(606, 717);
            dataGridView1.TabIndex = 0;
            // 
            // MaDauSach
            // 
            MaDauSach.HeaderText = "Mã đầu sách";
            MaDauSach.MinimumWidth = 9;
            MaDauSach.Name = "MaDauSach";
            MaDauSach.Width = 175;
            // 
            // TenDauSach
            // 
            TenDauSach.HeaderText = "Tên đầu sách";
            TenDauSach.MinimumWidth = 9;
            TenDauSach.Name = "TenDauSach";
            TenDauSach.Width = 175;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(762, 347);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 751);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu sách";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(594, 717);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã đầu sách";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên đầu sách";
            dataGridViewTextBoxColumn2.MinimumWidth = 9;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 175;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.Location = new Point(1479, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 751);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đầu sách";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 31);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.Size = new Size(424, 717);
            dataGridView3.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Mã đầu sách";
            dataGridViewTextBoxColumn3.MinimumWidth = 9;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tên đầu sách";
            dataGridViewTextBoxColumn4.MinimumWidth = 9;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 175;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1368, 640);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(108, 79);
            guna2Button1.TabIndex = 25;
            guna2Button1.Text = "gunn1";
            // 
            // UC_TacGiaSach
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grbDauSach);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboMode);
            Controls.Add(txtSearch);
            Controls.Add(cboTruong);
            Controls.Add(lblQLTacGiaSach);
            ForeColor = Color.Black;
            Name = "UC_TacGiaSach";
            Size = new Size(2035, 1277);
            Load += UC_TacGiaSach_Load;
            grbDauSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQLTacGiaSach;
        private RadioButton radBtnXem;
        private GroupBox grbMode;
        private RadioButton radBtnSua;
        private Guna.UI2.WinForms.Guna2ComboBox cboTruong;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboMode;
        private Label label1;
        private Label label2;
        private GroupBox grbDauSach;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaDauSach;
        private DataGridViewTextBoxColumn TenDauSach;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private GroupBox groupBox2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
