using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Layout_QLTV.Child_UC
{
    public partial class UC_DauSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;
        public UC_DauSach()
        {
            InitializeComponent();
        }

        private void LoadComboBox(ComboBox cbo, string tableName, string Ma, string TenMa)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = $"SELECT * FROM {tableName}";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbo.DataSource = dt;
                    cbo.ValueMember = Ma;
                    cbo.DisplayMember = TenMa;
                    cbo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void UC_DauSach_Load(object sender, EventArgs e)
        {
            ShowDauSach();
            LoadComboBox(cboMaLoaiSach, "LoaiSach", "MaLoaiSach", "TenLoaiSach");
            LoadComboBox(cboMaChuDe, "ChuDe", "MaChuDe", "TenChuDe");
            LoadComboBox(cboMaNXB, "NXB", "MaNXB", "TenNXB");
            LoadComboBox(cboMaKho, "KhoSach", "MaKho", "TenKho");
        }

        private void ShowDauSach()
        {
            using (con = new SqlConnection(strCon))
            {
                string sql = "Select * from DauSach";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            dv = new DataView(dt);
            dgvDSDauSach.DataSource = dv;
        }

        private void NapCT()
        {
            if (dgvDSDauSach.CurrentRow != null && dgvDSDauSach.CurrentRow.Index >= 0)
            {
                int i = dgvDSDauSach.CurrentRow.Index;
                txtMaDauSach.Text = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value.ToString();
                //txtMaDauSach.Enabled = string.IsNullOrEmpty(txtMaDauSach.Text);

                txtTenDauSach.Text = dgvDSDauSach.Rows[i].Cells["TenDauSach"].Value.ToString();
                txtNamXB.Text = dgvDSDauSach.Rows[i].Cells["NamXuatBan"].Value.ToString();
                txtGiaBia.Text = dgvDSDauSach.Rows[i].Cells["GiaBia"].Value.ToString();
                txtSoTrang.Text = dgvDSDauSach.Rows[i].Cells["SoTrang"].Value.ToString();

                cboMaLoaiSach.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaLoaiSach"].Value.ToString();
                cboMaChuDe.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value.ToString();
                cboMaNXB.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaNXB"].Value.ToString();
                cboMaKho.SelectedValue = dgvDSDauSach.Rows[i].Cells["MaKho"].Value.ToString();
            }
        }

        private void dgvDSDauSach_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

            txtMaDauSach.Enabled = true;

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";

            cboMaLoaiSach.SelectedIndex = 0;
            cboMaChuDe.SelectedIndex = 0;
            cboMaNXB.SelectedIndex = 0;
            cboMaKho.SelectedIndex = 0;

            txtMaDauSach.Focus();
            addNewFlag = true;
        }

        void DoSQL(string sql)
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (addNewFlag)
                {
                    string maDauSach = txtMaDauSach.Text.Trim();
                    string tenDauSach = txtTenDauSach.Text.Trim();
                    string namXB = txtNamXB.Text.Trim();
                    string giaBia = txtGiaBia.Text.Trim();
                    string soTrang = txtSoTrang.Text.Trim();
                    string maLoaiSach = cboMaLoaiSach.SelectedValue?.ToString();
                    string maChuDe = cboMaChuDe.SelectedValue?.ToString();
                    string maNXB = cboMaNXB.SelectedValue?.ToString();
                    string maKho = cboMaKho.SelectedValue?.ToString();

                    string sql = $"INSERT INTO DauSach VALUES ('{maDauSach}', '{tenDauSach}', {namXB}, {giaBia}," +
                        $" {soTrang}, '{maLoaiSach}', '{maChuDe}', '{maNXB}', '{maKho}')";
                    DoSQL(sql);
                    MessageBox.Show($"Đã thêm thành công bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDauSach();
                    addNewFlag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi them du lieu " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDauSach.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    int i = dgvDSDauSach.CurrentRow.Index;
                    string maDauSach = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value.ToString();
                    string sql = $"Delete from DauSach where MaDauSach = '{maDauSach}'";
                    DoSQL(sql);
                    MessageBox.Show($"Đã xoá bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDauSach();
                }
            }
            else
            {
                MessageBox.Show("Chua chon ban ghi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (addNewFlag == false)
            {
                int n = dgvDSDauSach.RowCount;
                for (int i = 0; i < n - 1; i++)
                {
                    string maDauSach = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value.ToString();
                    string tenDauSach = dgvDSDauSach.Rows[i].Cells["TenDauSach"].Value.ToString();
                    string namXB = dgvDSDauSach.Rows[i].Cells["NamXuatBan"].Value.ToString();
                    string giaBia = dgvDSDauSach.Rows[i].Cells["GiaBia"].Value.ToString();
                    string soTrang = dgvDSDauSach.Rows[i].Cells["SoTrang"].Value.ToString();

                    string maLoaiSach = dgvDSDauSach.Rows[i].Cells["MaLoaiSach"].Value.ToString();
                    string maChuDe = dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value.ToString();
                    string maNXB = dgvDSDauSach.Rows[i].Cells["MaNXB"].Value.ToString();
                    string maKho = dgvDSDauSach.Rows[i].Cells["MaKho"].Value.ToString();

                    string sql = $"UPDATE DauSach SET " +
                        $"TenDauSach = N'{tenDauSach}', " +
                        $"NamXuatBan = {namXB}, " +
                        $"GiaBia = {giaBia}, " +
                        $"SoTrang = {soTrang}, " +
                        $"MaLoaiSach = '{maLoaiSach}', " +
                        $"MaChuDe = '{maChuDe}', " +
                        $"MaNXB = '{maNXB}', " +
                        $"MaKho = '{maKho}' " +
                        $"WHERE MaDauSach = '{maDauSach}'";
                    DoSQL(sql);
                }
                MessageBox.Show($"Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowDauSach();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dv.RowFilter = $"TenDauSach like '%{search}%'";
        }
    }
}
