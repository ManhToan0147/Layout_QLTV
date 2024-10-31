using System;
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
    public partial class UC_ChiTietSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;
        DataView dv;

        private IContainer components;
        private DataGridView dgvChiTietDauSach;
        private Panel panelSearching;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna2ComboBox cboNXB;
        private Guna2ComboBox cboKho;
        private Guna2ComboBox cboLoaiSach;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Guna2Button btnXemChiTiet;
        private DataGridViewTextBoxColumn MaDauSach;
        private DataGridViewTextBoxColumn TenDauSach;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn GiaBia;
        private DataGridViewTextBoxColumn SoTrang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenLoaiSach;
        private DataGridViewTextBoxColumn TenChuDe;
        private DataGridViewTextBoxColumn TenNXB;
        private DataGridViewTextBoxColumn TenKho;
        private Label label5;
        private Guna2ComboBox cboTacGia;
        private Guna2ComboBox cboChuDe;

        public UC_ChiTietSach()
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblQuanLySach = new Label();
            panelContainer = new Panel();
            dgvChiTietDauSach = new DataGridView();
            MaDauSach = new DataGridViewTextBoxColumn();
            TenDauSach = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
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
            label5 = new Label();
            label1 = new Label();
            cboNXB = new Guna2ComboBox();
            cboKho = new Guna2ComboBox();
            cboTacGia = new Guna2ComboBox();
            cboLoaiSach = new Guna2ComboBox();
            txtSearch = new Guna2TextBox();
            btnXemChiTiet = new Guna2Button();
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
            lblQuanLySach.Location = new Point(780, 30);
            lblQuanLySach.Name = "lblQuanLySach";
            lblQuanLySach.Size = new Size(435, 74);
            lblQuanLySach.TabIndex = 1;
            lblQuanLySach.Text = "QUẢN LÝ SÁCH";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(dgvChiTietDauSach);
            panelContainer.Location = new Point(53, 480);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1927, 657);
            panelContainer.TabIndex = 2;
            // 
            // dgvChiTietDauSach
            // 
            dgvChiTietDauSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(2, 76, 170);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvChiTietDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietDauSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvChiTietDauSach.Columns.AddRange(new DataGridViewColumn[] { MaDauSach, TenDauSach, TenTacGia, NamXuatBan, GiaBia, SoTrang, SoLuong, TenLoaiSach, TenChuDe, TenNXB, TenKho });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(2, 76, 170);
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
            dgvChiTietDauSach.Size = new Size(1927, 657);
            dgvChiTietDauSach.TabIndex = 0;
            // 
            // MaDauSach
            // 
            MaDauSach.DataPropertyName = "MaDauSach";
            MaDauSach.HeaderText = "Mã đầu sách";
            MaDauSach.MinimumWidth = 9;
            MaDauSach.Name = "MaDauSach";
            // 
            // TenDauSach
            // 
            TenDauSach.DataPropertyName = "TenDauSach";
            TenDauSach.HeaderText = "Tên đầu sách";
            TenDauSach.MinimumWidth = 9;
            TenDauSach.Name = "TenDauSach";
            // 
            // TenTacGia
            // 
            TenTacGia.DataPropertyName = "TenTacGia";
            TenTacGia.HeaderText = "Tác giả";
            TenTacGia.MinimumWidth = 9;
            TenTacGia.Name = "TenTacGia";
            // 
            // NamXuatBan
            // 
            NamXuatBan.DataPropertyName = "NamXuatBan";
            NamXuatBan.HeaderText = "Năm XB";
            NamXuatBan.MinimumWidth = 9;
            NamXuatBan.Name = "NamXuatBan";
            // 
            // GiaBia
            // 
            GiaBia.DataPropertyName = "GiaBia";
            GiaBia.HeaderText = "Giá bìa";
            GiaBia.MinimumWidth = 9;
            GiaBia.Name = "GiaBia";
            // 
            // SoTrang
            // 
            SoTrang.DataPropertyName = "SoTrang";
            SoTrang.HeaderText = "Số trang";
            SoTrang.MinimumWidth = 9;
            SoTrang.Name = "SoTrang";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 9;
            SoLuong.Name = "SoLuong";
            // 
            // TenLoaiSach
            // 
            TenLoaiSach.DataPropertyName = "TenLoaiSach";
            TenLoaiSach.HeaderText = "Loại sách";
            TenLoaiSach.MinimumWidth = 9;
            TenLoaiSach.Name = "TenLoaiSach";
            // 
            // TenChuDe
            // 
            TenChuDe.DataPropertyName = "TenChuDe";
            TenChuDe.HeaderText = "Chủ đề";
            TenChuDe.MinimumWidth = 9;
            TenChuDe.Name = "TenChuDe";
            // 
            // TenNXB
            // 
            TenNXB.DataPropertyName = "TenNXB";
            TenNXB.HeaderText = "NXB";
            TenNXB.MinimumWidth = 9;
            TenNXB.Name = "TenNXB";
            // 
            // TenKho
            // 
            TenKho.DataPropertyName = "TenKho";
            TenKho.HeaderText = "Kho";
            TenKho.MinimumWidth = 9;
            TenKho.Name = "TenKho";
            // 
            // panelSearching
            // 
            panelSearching.BackColor = Color.LightBlue;
            panelSearching.Controls.Add(cboChuDe);
            panelSearching.Controls.Add(label2);
            panelSearching.Controls.Add(label4);
            panelSearching.Controls.Add(label3);
            panelSearching.Controls.Add(label5);
            panelSearching.Controls.Add(label1);
            panelSearching.Controls.Add(cboNXB);
            panelSearching.Controls.Add(cboKho);
            panelSearching.Controls.Add(cboTacGia);
            panelSearching.Controls.Add(cboLoaiSach);
            panelSearching.Controls.Add(txtSearch);
            panelSearching.ForeColor = Color.Black;
            panelSearching.Location = new Point(53, 136);
            panelSearching.Name = "panelSearching";
            panelSearching.Size = new Size(1927, 271);
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
            cboChuDe.Location = new Point(599, 201);
            cboChuDe.MaxDropDownItems = 15;
            cboChuDe.Name = "cboChuDe";
            cboChuDe.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboChuDe.Size = new Size(520, 46);
            cboChuDe.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(599, 170);
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
            label4.Location = new Point(1594, 168);
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
            label3.Location = new Point(1144, 166);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 5;
            label3.Text = "Chọn NXB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(270, 168);
            label5.Name = "label5";
            label5.Size = new Size(136, 30);
            label5.TabIndex = 5;
            label5.Text = "Chọn tác giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 168);
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
            cboNXB.Location = new Point(1144, 201);
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
            cboKho.Location = new Point(1594, 201);
            cboKho.Name = "cboKho";
            cboKho.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboKho.Size = new Size(305, 46);
            cboKho.TabIndex = 3;
            // 
            // cboTacGia
            // 
            cboTacGia.BackColor = Color.Transparent;
            cboTacGia.CustomizableEdges = customizableEdges7;
            cboTacGia.DrawMode = DrawMode.OwnerDrawFixed;
            cboTacGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTacGia.FocusedColor = Color.FromArgb(94, 148, 255);
            cboTacGia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboTacGia.Font = new Font("Segoe UI", 10F);
            cboTacGia.ForeColor = Color.Black;
            cboTacGia.IntegralHeight = false;
            cboTacGia.ItemHeight = 40;
            cboTacGia.Location = new Point(270, 201);
            cboTacGia.MaxDropDownItems = 15;
            cboTacGia.Name = "cboTacGia";
            cboTacGia.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboTacGia.Size = new Size(303, 46);
            cboTacGia.TabIndex = 1;
            // 
            // cboLoaiSach
            // 
            cboLoaiSach.BackColor = Color.Transparent;
            cboLoaiSach.CustomizableEdges = customizableEdges9;
            cboLoaiSach.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSach.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.Font = new Font("Segoe UI", 10F);
            cboLoaiSach.ForeColor = Color.Black;
            cboLoaiSach.ItemHeight = 40;
            cboLoaiSach.Location = new Point(27, 201);
            cboLoaiSach.Name = "cboLoaiSach";
            cboLoaiSach.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cboLoaiSach.Size = new Size(219, 46);
            cboLoaiSach.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 36;
            txtSearch.CustomizableEdges = customizableEdges11;
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSearch.Size = new Size(1240, 75);
            txtSearch.TabIndex = 0;
            txtSearch.TextOffset = new Point(10, 0);
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.BorderColor = Color.Transparent;
            btnXemChiTiet.BorderThickness = 2;
            btnXemChiTiet.CustomizableEdges = customizableEdges13;
            btnXemChiTiet.DisabledState.BorderColor = Color.DarkGray;
            btnXemChiTiet.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXemChiTiet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXemChiTiet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXemChiTiet.FillColor = Color.FromArgb(0, 172, 232);
            btnXemChiTiet.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXemChiTiet.ForeColor = Color.White;
            btnXemChiTiet.HoverState.BorderColor = Color.FromArgb(0, 172, 232);
            btnXemChiTiet.HoverState.FillColor = Color.White;
            btnXemChiTiet.HoverState.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXemChiTiet.HoverState.ForeColor = Color.FromArgb(0, 172, 232);
            btnXemChiTiet.ImageSize = new Size(0, 0);
            btnXemChiTiet.Location = new Point(409, 1178);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnXemChiTiet.Size = new Size(1216, 79);
            btnXemChiTiet.TabIndex = 6;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // UC_ChiTietSach
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(btnXemChiTiet);
            Controls.Add(panelSearching);
            Controls.Add(panelContainer);
            Controls.Add(lblQuanLySach);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "UC_ChiTietSach";
            Size = new Size(2035, 1277);
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
            LoadComboBox(cboTacGia, "TacGia", "TenTG");
            // Đăng ký sự kiện SelectedIndexChanged cho ComboBox và TextChanged cho TextBox
            cboTacGia.SelectedIndexChanged += FilterData;
            cboLoaiSach.SelectedIndexChanged += FilterData;
            cboChuDe.SelectedIndexChanged += FilterData;
            cboNXB.SelectedIndexChanged += FilterData;
            cboKho.SelectedIndexChanged += FilterData;
            txtSearch.TextChanged += FilterData;
        }

        private void FilterData(object sender, EventArgs e)
        {
            string tacGia = cboTacGia.Text == "Tất cả" ? "" : cboTacGia.Text;
            string loaiSach = cboLoaiSach.Text == "Tất cả" ? "" : cboLoaiSach.Text;
            string chuDe = cboChuDe.Text == "Tất cả" ? "" : cboChuDe.Text;
            string nxb = cboNXB.Text == "Tất cả" ? "" : cboNXB.Text;
            string kho = cboKho.Text == "Tất cả" ? "" : cboKho.Text;
            string search = txtSearch.Text;

            // Xây dựng bộ lọc
            string filter = "";
            if (!string.IsNullOrEmpty(loaiSach))
                filter += $"TenLoaiSach = '{loaiSach}'";
            if (!string.IsNullOrEmpty(tacGia))
                filter += (filter == "" ? "" : " AND ") + $"TenTacGia LIKE '%{tacGia}%'";
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

                    // Thêm tùy chọn "Tất cả" vào DataTable
                    DataRow allRow = dt.NewRow();
                    allRow[columnName] = "Tất cả";
                    dt.Rows.InsertAt(allRow, 0); // Đưa vào đầu danh sách

                    // Gán dữ liệu vào ComboBox
                    cbo.DataSource = dt;
                    cbo.DisplayMember = columnName; // Hiển thị tên
                    cbo.SelectedIndex = 0; // Mặc định chọn "Tất cả"
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

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDauSach.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                DataGridViewRow selectedRow = dgvChiTietDauSach.SelectedRows[0]; // Lấy hàng được chọn

                // Khởi tạo form chi tiết và truyền dữ liệu
                ChiTietSach cts = new ChiTietSach();
                cts.LoadBookDetails(selectedRow); // Gọi phương thức để hiển thị chi tiết

                cts.ShowDialog(); // Hiển thị form chi tiết dưới dạng dialog
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đầu sách để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
