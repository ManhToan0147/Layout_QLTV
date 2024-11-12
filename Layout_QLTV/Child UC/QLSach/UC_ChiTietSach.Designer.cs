using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout_QLTV.Child_UC.QLSach
{
    public partial class UC_ChiTietSach : UserControl
    {
        // Khai báo các thành phần giao diện
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
        private Label lblQuanLySach;
        private Panel panelContainer;
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(2, 76, 170);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dgvChiTietDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvChiTietDauSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDauSach.BorderStyle = BorderStyle.None;
            dgvChiTietDauSach.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvChiTietDauSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(0, 172, 232);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 172, 232);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvChiTietDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvChiTietDauSach.ColumnHeadersHeight = 50;
            dgvChiTietDauSach.Columns.AddRange(new DataGridViewColumn[] { MaDauSach, TenDauSach, TenTacGia, NamXuatBan, GiaBia, SoTrang, SoLuong, TenLoaiSach, TenChuDe, TenNXB, TenKho });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(2, 76, 170);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvChiTietDauSach.DefaultCellStyle = dataGridViewCellStyle11;
            dgvChiTietDauSach.Dock = DockStyle.Fill;
            dgvChiTietDauSach.EnableHeadersVisualStyles = false;
            dgvChiTietDauSach.Location = new Point(0, 0);
            dgvChiTietDauSach.Name = "dgvChiTietDauSach";
            dgvChiTietDauSach.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvChiTietDauSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            cboChuDe.CustomizableEdges = customizableEdges29;
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
            cboChuDe.ShadowDecoration.CustomizableEdges = customizableEdges30;
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
            cboNXB.CustomizableEdges = customizableEdges31;
            cboNXB.DrawMode = DrawMode.OwnerDrawFixed;
            cboNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNXB.FocusedColor = Color.FromArgb(94, 148, 255);
            cboNXB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboNXB.Font = new Font("Segoe UI", 10F);
            cboNXB.ForeColor = Color.Black;
            cboNXB.ItemHeight = 40;
            cboNXB.Location = new Point(1144, 201);
            cboNXB.Name = "cboNXB";
            cboNXB.ShadowDecoration.CustomizableEdges = customizableEdges32;
            cboNXB.Size = new Size(428, 46);
            cboNXB.TabIndex = 4;
            // 
            // cboKho
            // 
            cboKho.BackColor = Color.Transparent;
            cboKho.CustomizableEdges = customizableEdges33;
            cboKho.DrawMode = DrawMode.OwnerDrawFixed;
            cboKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKho.FocusedColor = Color.FromArgb(94, 148, 255);
            cboKho.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboKho.Font = new Font("Segoe UI", 10F);
            cboKho.ForeColor = Color.Black;
            cboKho.ItemHeight = 40;
            cboKho.Location = new Point(1594, 201);
            cboKho.Name = "cboKho";
            cboKho.ShadowDecoration.CustomizableEdges = customizableEdges34;
            cboKho.Size = new Size(305, 46);
            cboKho.TabIndex = 3;
            // 
            // cboTacGia
            // 
            cboTacGia.BackColor = Color.Transparent;
            cboTacGia.CustomizableEdges = customizableEdges35;
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
            cboTacGia.ShadowDecoration.CustomizableEdges = customizableEdges36;
            cboTacGia.Size = new Size(303, 46);
            cboTacGia.TabIndex = 1;
            // 
            // cboLoaiSach
            // 
            cboLoaiSach.BackColor = Color.Transparent;
            cboLoaiSach.CustomizableEdges = customizableEdges37;
            cboLoaiSach.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSach.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSach.Font = new Font("Segoe UI", 10F);
            cboLoaiSach.ForeColor = Color.Black;
            cboLoaiSach.ItemHeight = 40;
            cboLoaiSach.Location = new Point(27, 201);
            cboLoaiSach.Name = "cboLoaiSach";
            cboLoaiSach.ShadowDecoration.CustomizableEdges = customizableEdges38;
            cboLoaiSach.Size = new Size(219, 46);
            cboLoaiSach.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 36;
            txtSearch.CustomizableEdges = customizableEdges39;
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges40;
            txtSearch.Size = new Size(1240, 75);
            txtSearch.TabIndex = 0;
            txtSearch.TextOffset = new Point(10, 0);
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Anchor = AnchorStyles.Top;
            btnXemChiTiet.BorderColor = Color.Transparent;
            btnXemChiTiet.BorderThickness = 2;
            btnXemChiTiet.CustomizableEdges = customizableEdges41;
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
            btnXemChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges42;
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
            Load += UC_ChiTietSach_Load;
            panelContainer.ResumeLayout(false);
            ((ISupportInitialize)dgvChiTietDauSach).EndInit();
            panelSearching.ResumeLayout(false);
            panelSearching.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
