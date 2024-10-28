﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace Layout_QLTV
{
    public partial class UC_QuanLySach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;
        DataView dv;

        private IContainer components;
        private DataGridView dgvChiTietDauSach;
        private DataGridViewTextBoxColumn MaDauSach;
        private DataGridViewTextBoxColumn TenDauSach;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn GiaBia;
        private DataGridViewTextBoxColumn SoTrang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenLoaiSach;
        private DataGridViewTextBoxColumn TenChuDe;
        private DataGridViewTextBoxColumn TenNXB;
        private DataGridViewTextBoxColumn TenKho;
        private Panel panelSearching;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna2ComboBox cboNXB;
        private Guna2ComboBox cboKho;
        private Guna2ComboBox cboLoaiSach;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Guna2ComboBox cboChuDe;

        public UC_QuanLySach()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblQuanLySach = new Label();
            panelContainer = new Panel();
            dgvChiTietDauSach = new DataGridView();
            MaDauSach = new DataGridViewTextBoxColumn();
            TenDauSach = new DataGridViewTextBoxColumn();
            NamXuatBan = new DataGridViewTextBoxColumn();
            GiaBia = new DataGridViewTextBoxColumn();
            SoTrang = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TenLoaiSach = new DataGridViewTextBoxColumn();
            TenChuDe = new DataGridViewTextBoxColumn();
            TenNXB = new DataGridViewTextBoxColumn();
            TenKho = new DataGridViewTextBoxColumn();
            panelSearching = new Panel();
            cboChuDe = new Guna2ComboBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            cboNXB = new Guna2ComboBox();
            cboKho = new Guna2ComboBox();
            cboLoaiSach = new Guna2ComboBox();
            txtSearch = new Guna2TextBox();
            panelContainer.SuspendLayout();
            ((ISupportInitialize)dgvChiTietDauSach).BeginInit();
            panelSearching.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuanLySach
            // 
            lblQuanLySach.AutoSize = true;
            lblQuanLySach.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLySach.ForeColor = Color.FromArgb(2, 76, 170);
            lblQuanLySach.Location = new Point(774, 16);
            lblQuanLySach.Name = "lblQuanLySach";
            lblQuanLySach.Size = new Size(435, 74);
            lblQuanLySach.TabIndex = 1;
            lblQuanLySach.Text = "QUẢN LÝ SÁCH";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(dgvChiTietDauSach);
            panelContainer.Location = new Point(57, 436);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1915, 688);
            panelContainer.TabIndex = 2;
            // 
            // dgvChiTietDauSach
            // 
            dgvChiTietDauSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvChiTietDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietDauSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvChiTietDauSach.BorderStyle = BorderStyle.None;
            dgvChiTietDauSach.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvChiTietDauSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 172, 232);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 172, 232);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTietDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietDauSach.ColumnHeadersHeight = 50;
            dgvChiTietDauSach.Columns.AddRange(new DataGridViewColumn[] { MaDauSach, TenDauSach, NamXuatBan, GiaBia, SoTrang, SoLuong, TenLoaiSach, TenChuDe, TenNXB, TenKho });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTietDauSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietDauSach.Dock = DockStyle.Fill;
            dgvChiTietDauSach.EnableHeadersVisualStyles = false;
            dgvChiTietDauSach.Location = new Point(0, 0);
            dgvChiTietDauSach.Name = "dgvChiTietDauSach";
            dgvChiTietDauSach.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvChiTietDauSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChiTietDauSach.RowHeadersWidth = 72;
            dgvChiTietDauSach.RowTemplate.Height = 50;
            dgvChiTietDauSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietDauSach.Size = new Size(1915, 688);
            dgvChiTietDauSach.TabIndex = 0;
            // 
            // MaDauSach
            // 
            MaDauSach.DataPropertyName = "MaDauSach";
            MaDauSach.HeaderText = "Mã đầu sách";
            MaDauSach.MinimumWidth = 9;
            MaDauSach.Name = "MaDauSach";
            MaDauSach.Width = 175;
            // 
            // TenDauSach
            // 
            TenDauSach.DataPropertyName = "TenDauSach";
            TenDauSach.HeaderText = "Tên đầu sách";
            TenDauSach.MinimumWidth = 9;
            TenDauSach.Name = "TenDauSach";
            TenDauSach.Width = 178;
            // 
            // NamXuatBan
            // 
            NamXuatBan.DataPropertyName = "NamXuatBan";
            NamXuatBan.HeaderText = "Năm XB";
            NamXuatBan.MinimumWidth = 9;
            NamXuatBan.Name = "NamXuatBan";
            NamXuatBan.Width = 132;
            // 
            // GiaBia
            // 
            GiaBia.DataPropertyName = "GiaBia";
            GiaBia.HeaderText = "Giá bìa";
            GiaBia.MinimumWidth = 9;
            GiaBia.Name = "GiaBia";
            GiaBia.Width = 120;
            // 
            // SoTrang
            // 
            SoTrang.DataPropertyName = "SoTrang";
            SoTrang.HeaderText = "Số trang";
            SoTrang.MinimumWidth = 9;
            SoTrang.Name = "SoTrang";
            SoTrang.Width = 136;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 9;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 142;
            // 
            // TenLoaiSach
            // 
            TenLoaiSach.DataPropertyName = "TenLoaiSach";
            TenLoaiSach.HeaderText = "Loại sách";
            TenLoaiSach.MinimumWidth = 9;
            TenLoaiSach.Name = "TenLoaiSach";
            TenLoaiSach.Width = 142;
            // 
            // TenChuDe
            // 
            TenChuDe.DataPropertyName = "TenChuDe";
            TenChuDe.HeaderText = "Chủ đề";
            TenChuDe.MinimumWidth = 9;
            TenChuDe.Name = "TenChuDe";
            TenChuDe.Width = 121;
            // 
            // TenNXB
            // 
            TenNXB.DataPropertyName = "TenNXB";
            TenNXB.HeaderText = "NXB";
            TenNXB.MinimumWidth = 9;
            TenNXB.Name = "TenNXB";
            TenNXB.Width = 96;
            // 
            // TenKho
            // 
            TenKho.DataPropertyName = "TenKho";
            TenKho.HeaderText = "Kho";
            TenKho.MinimumWidth = 9;
            TenKho.Name = "TenKho";
            TenKho.Width = 92;
            // 
            // panelSearching
            // 
            panelSearching.BackColor = Color.LightBlue;
            panelSearching.Controls.Add(cboChuDe);
            panelSearching.Controls.Add(label2);
            panelSearching.Controls.Add(label4);
            panelSearching.Controls.Add(label3);
            panelSearching.Controls.Add(label1);
            panelSearching.Controls.Add(cboNXB);
            panelSearching.Controls.Add(cboKho);
            panelSearching.Controls.Add(cboLoaiSach);
            panelSearching.Controls.Add(txtSearch);
            panelSearching.ForeColor = Color.Black;
            panelSearching.Location = new Point(57, 109);
            panelSearching.Name = "panelSearching";
            panelSearching.Size = new Size(1915, 271);
            panelSearching.TabIndex = 3;
            // 
            // cboChuDe
            // 
            cboChuDe.BackColor = Color.Transparent;
            cboChuDe.CustomizableEdges = customizableEdges1;
            cboChuDe.DrawMode = DrawMode.OwnerDrawFixed;
            cboChuDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChuDe.FocusedColor = Color.FromArgb(94, 148, 255);
            cboChuDe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboChuDe.Font = new Font("Segoe UI", 10F);
            cboChuDe.ForeColor = Color.FromArgb(68, 88, 112);
            cboChuDe.IntegralHeight = false;
            cboChuDe.ItemHeight = 40;
            cboChuDe.Location = new Point(383, 201);
            cboChuDe.MaxDropDownItems = 15;
            cboChuDe.Name = "cboChuDe";
            cboChuDe.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboChuDe.Size = new Size(559, 46);
            cboChuDe.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(383, 170);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 5;
            label2.Text = "Chọn chủ đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1486, 168);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 5;
            label4.Text = "Chọn kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(997, 166);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 5;
            label3.Text = "Chọn NXB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 168);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 5;
            label1.Text = "Chọn loại sách";
            // 
            // cboNXB
            // 
            cboNXB.BackColor = Color.Transparent;
            cboNXB.CustomizableEdges = customizableEdges3;
            cboNXB.DrawMode = DrawMode.OwnerDrawFixed;
            cboNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNXB.FocusedColor = Color.FromArgb(94, 148, 255);
            cboNXB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboNXB.Font = new Font("Segoe UI", 10F);
            cboNXB.ForeColor = Color.Black;
            cboNXB.ItemHeight = 40;
            cboNXB.Location = new Point(997, 201);
            cboNXB.Name = "cboNXB";
            cboNXB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboNXB.Size = new Size(428, 46);
            cboNXB.TabIndex = 4;
            // 
            // cboKho
            // 
            cboKho.BackColor = Color.Transparent;
            cboKho.CustomizableEdges = customizableEdges5;
            cboKho.DrawMode = DrawMode.OwnerDrawFixed;
            cboKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKho.FocusedColor = Color.FromArgb(94, 148, 255);
            cboKho.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboKho.Font = new Font("Segoe UI", 10F);
            cboKho.ForeColor = Color.Black;
            cboKho.ItemHeight = 40;
            cboKho.Location = new Point(1486, 201);
            cboKho.Name = "cboKho";
            cboKho.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboKho.Size = new Size(375, 46);
            cboKho.TabIndex = 3;
            // 
            // cboLoaiSach
            // 
            cboLoaiSach.BackColor = Color.Transparent;
            cboLoaiSach.CustomizableEdges = customizableEdges7;
            cboLoaiSach.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSach.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.Font = new Font("Segoe UI", 10F);
            cboLoaiSach.ForeColor = Color.Black;
            cboLoaiSach.ItemHeight = 40;
            cboLoaiSach.Location = new Point(55, 201);
            cboLoaiSach.Name = "cboLoaiSach";
            cboLoaiSach.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboLoaiSach.Size = new Size(266, 46);
            cboLoaiSach.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 36;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.FocusedState.ForeColor = Color.Black;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.search;
            txtSearch.IconLeftOffset = new Point(20, 0);
            txtSearch.IconLeftSize = new Size(25, 25);
            txtSearch.IconRightSize = new Size(0, 0);
            txtSearch.Location = new Point(337, 53);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.DimGray;
            txtSearch.PlaceholderText = "Nhập để tìm kiếm đầu sách";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(1240, 75);
            txtSearch.TabIndex = 0;
            txtSearch.TextOffset = new Point(10, 0);
            // 
            // UC_QuanLySach
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panelSearching);
            Controls.Add(panelContainer);
            Controls.Add(lblQuanLySach);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "UC_QuanLySach";
            Size = new Size(2035, 1289);
            Load += UC_QuanLySach_Load;
            panelContainer.ResumeLayout(false);
            ((ISupportInitialize)dgvChiTietDauSach).EndInit();
            panelSearching.ResumeLayout(false);
            panelSearching.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void UC_QuanLySach_Load(object sender, EventArgs e)
        {
            ShowChiTietDauSach();
            dgvChiTietDauSach.ForeColor = Color.Black;
            LoadComboBox(cboLoaiSach, "LoaiSach", "TenLoaiSach");
            LoadComboBox(cboChuDe, "ChuDe", "TenChuDe");
            LoadComboBox(cboNXB, "NXB", "TenNXB");
            LoadComboBox(cboKho, "KhoSach", "TenKho");
            // Đăng ký sự kiện SelectedIndexChanged cho ComboBox và TextChanged cho TextBox
            cboLoaiSach.SelectedIndexChanged += FilterData;
            cboChuDe.SelectedIndexChanged += FilterData;
            cboNXB.SelectedIndexChanged += FilterData;
            cboKho.SelectedIndexChanged += FilterData;
            txtSearch.TextChanged += FilterData;
        }

        private void FilterData(object sender, EventArgs e)
        {
            string loaiSach = cboLoaiSach.Text;
            string chuDe = cboChuDe.Text;
            string nxb = cboNXB.Text;
            string kho = cboKho.Text;
            string search = txtSearch.Text;

            // Xây dựng bộ lọc
            string filter = "";

            if (!string.IsNullOrEmpty(loaiSach))
                filter += $"TenLoaiSach = '{loaiSach}'";
            if (!string.IsNullOrEmpty(chuDe))
                filter += (filter == "" ? "" : " AND ") + $"TenChuDe = '{chuDe}'";
            if (!string.IsNullOrEmpty(nxb))
                filter += (filter == "" ? "" : " AND ") + $"TenNXB = '{nxb}'";
            if (!string.IsNullOrEmpty(kho))
                filter += (filter == "" ? "" : " AND ") + $"TenKho = '{kho}'";
            if (!string.IsNullOrEmpty(search))
                filter += (filter == "" ? "" : " AND ") + $"TenDauSach LIKE '%{search}%'";

            // Áp dụng bộ lọc vào DataView
            dv.RowFilter = filter;
        }

        private void LoadComboBox(ComboBox cbo, string tableName, string columnName)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = $"SELECT {columnName} FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Gán dữ liệu vào ComboBox
                    cbo.DataSource = dt;
                    cbo.DisplayMember = columnName; // Hiển thị tên
                    cbo.SelectedIndex = -1; // Không chọn mục nào lúc đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void ShowChiTietDauSach()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string sql = "Select * from ChiTiet_DauSach";
            adapter = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            adapter.Fill(dt);
            dv = new DataView(dt); // Tạo DataView từ DataTable để dùng cho bộ lọc
            dgvChiTietDauSach.DataSource = dv;
            con.Close();
        }

        private Label lblQuanLySach;
        private Panel panelContainer;
    }
}