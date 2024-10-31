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
        public UC_DauSach()
        {
            InitializeComponent();
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

                    cbo.DataSource = dt;
                    cbo.DisplayMember = columnName;
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
            LoadComboBox(cboMaLoaiSach, "LoaiSach", "MaLoaiSach");
            LoadComboBox(cboMaChuDe, "ChuDe", "MaChuDe");
            LoadComboBox(cboMaNXB, "NXB", "MaNXB");
            LoadComboBox(cboMaKho, "KhoSach", "MaKho");
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

        private void dgvDSDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSDauSach.CurrentRow != null && dgvDSDauSach.CurrentRow.Index >= 0)
            {
                int i = dgvDSDauSach.CurrentRow.Index;
                txtMaDauSach.Text = dgvDSDauSach.Rows[i].Cells["MaDauSach"].Value.ToString();
                txtMaDauSach.Enabled = string.IsNullOrEmpty(txtMaDauSach.Text);

                txtTenDauSach.Text = dgvDSDauSach.Rows[i].Cells["TenDauSach"].Value.ToString();
                txtNamXB.Text = dgvDSDauSach.Rows[i].Cells["NamXuatBan"].Value.ToString();
                txtGiaBia.Text = dgvDSDauSach.Rows[i].Cells["GiaBia"].Value.ToString();
                txtSoTrang.Text = dgvDSDauSach.Rows[i].Cells["SoTrang"].Value.ToString();

                cboMaLoaiSach.Text = dgvDSDauSach.Rows[i].Cells["MaLoaiSach"].Value.ToString();
                cboMaChuDe.Text = dgvDSDauSach.Rows[i].Cells["MaChuDe"].Value.ToString();
                cboMaNXB.Text = dgvDSDauSach.Rows[i].Cells["MaNXB"].Value.ToString();
                cboMaKho.Text = dgvDSDauSach.Rows[i].Cells["MaKho"].Value.ToString();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

            txtMaDauSach.Enabled = true;

            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtNamXB.Text = "";
            txtGiaBia.Text = "";
            txtSoTrang.Text = "";

            cboMaLoaiSach.SelectedIndex = -1;
            cboMaChuDe.SelectedIndex = -1;
            cboMaNXB.SelectedIndex = -1;
            cboMaKho.SelectedIndex = -1;

            cboMaLoaiSach.Text = "";
            cboMaChuDe.Text = "";
            cboMaNXB.Text = "";
            cboMaKho.Text = "";

            txtMaDauSach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"Insert into DauSach values
                (@MaDauSach, @TenDauSach, @NamXuatBan, @GiaBia, @SoTrang, @MaLoaiSach, @MaChuDe, @MaNXB, @MaKho)";
            using (con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();
                    using (cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaDauSach", string.IsNullOrEmpty(txtMaDauSach.Text) ? (object)DBNull.Value : txtMaDauSach.Text);
                        cmd.Parameters.AddWithValue("@TenDauSach", string.IsNullOrEmpty(txtTenDauSach.Text) ? (object)DBNull.Value : txtTenDauSach.Text);
                        cmd.Parameters.AddWithValue("@NamXuatBan", string.IsNullOrEmpty(txtNamXB.Text) ? (object)DBNull.Value : int.Parse(txtNamXB.Text));
                        cmd.Parameters.AddWithValue("@GiaBia", string.IsNullOrEmpty(txtGiaBia.Text) ? (object)DBNull.Value : float.Parse(txtGiaBia.Text));
                        cmd.Parameters.AddWithValue("@SoTrang", string.IsNullOrEmpty(txtSoTrang.Text) ? (object)DBNull.Value : int.Parse(txtSoTrang.Text));
                        cmd.Parameters.AddWithValue("@MaLoaiSach", string.IsNullOrEmpty(cboMaLoaiSach.Text) ? (object)DBNull.Value : cboMaLoaiSach.Text);
                        cmd.Parameters.AddWithValue("@MaChuDe", string.IsNullOrEmpty(cboMaChuDe.Text) ? (object)DBNull.Value : cboMaChuDe.Text);
                        cmd.Parameters.AddWithValue("@MaNXB", string.IsNullOrEmpty(cboMaNXB.Text) ? (object)DBNull.Value : cboMaNXB.Text);
                        cmd.Parameters.AddWithValue("@MaKho", string.IsNullOrEmpty(cboMaKho.Text) ? (object)DBNull.Value : cboMaKho.Text);

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!");
                        } else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                        ShowDauSach();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}");
                }
            }
        }
    }
}
