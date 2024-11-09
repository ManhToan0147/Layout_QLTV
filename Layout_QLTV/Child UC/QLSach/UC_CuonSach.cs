using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace Layout_QLTV.Child_UC
{
    public partial class UC_CuonSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        bool addNewFlag = false;

        public UC_CuonSach()
        {
            InitializeComponent();
        }

        private void UC_CuonSach_Load(object sender, EventArgs e)
        {
            showDauSach();
            showCuonSach();
        }

        private void showCuonSach()
        {
            using (con = new SqlConnection(strCon))
            {
                string sql = "Select MaSach, TinhTrang from CuonSach";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            dgvCuonSach.DataSource = dt;
        }

        private void showDauSach()
        {
            using (con = new SqlConnection(strCon))
            {
                string sql = "Select MaDauSach, TenDauSach, ks.TenKho from DauSach ds left join KhoSach ks on ds.MaKho = ks.MaKho";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            dv = new DataView(dt);
            dgvDauSach.DataSource = dv;
        }

        //Lay ra ma dau sach dang duoc chon, de global cho tien
        private string selectedMaDauSach;

        private void ShowCuonSach_DauSach()
        {
            if (dgvDauSach.CurrentRow != null && dgvDauSach.CurrentRow.Index >= 0)
            {
                int i = dgvDauSach.CurrentRow.Index;
                var maDauSachCell = dgvDauSach.Rows[i].Cells["MaDauSach"].Value;
                if (maDauSachCell != null && !string.IsNullOrWhiteSpace(maDauSachCell.ToString()))
                {
                    selectedMaDauSach = maDauSachCell.ToString();

                    using (con = new SqlConnection(strCon))
                    {
                        con.Open();
                        string sql = $"Select MaSach, TinhTrang from CuonSach where MaDauSach = '{selectedMaDauSach}'";
                        using (adapter = new SqlDataAdapter(sql, con))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@MaDauSach", selectedMaDauSach);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dgvCuonSach.DataSource = dt;
                        }
                    }
                }
                else
                {
                    showCuonSach();
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                DataGridViewRow selectedRow = dgvDauSach.SelectedRows[0]; // Lấy hàng được chọn
                string maDauSach = selectedRow.Cells["MaDauSach"].Value.ToString(); // Lấy mã đầu sách từ cột "MaDauSach"

                // Khởi tạo form chi tiết và truyền mã đầu sách qua constructor
                ChiTietSach cts = new ChiTietSach(maDauSach);

                cts.ShowDialog(); // Hiển thị form chi tiết dưới dạng dialog
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đầu sách để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDauSach_SelectionChanged(object sender, EventArgs e)
        {
            ShowCuonSach_DauSach();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dv.RowFilter = $"TenDauSach LIKE '%{search}%'";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaDauSach))
            {
                MessageBox.Show("Vui lòng chọn một đầu sách trước khi sửa các cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (con = new SqlConnection(strCon))
            {
                int records = 0;
                con.Open();
                foreach (DataGridViewRow row in dgvCuonSach.Rows)
                {

                    if (row.IsNewRow || row.Cells["MaSach"].Value == null || row.Cells["TinhTrang"].Value == null)
                    {
                        continue;
                    }

                    string maSach = row.Cells["MaSach"].Value.ToString();
                    string tinhTrang = row.Cells["TinhTrang"].Value.ToString();
                    string sql = "Update CuonSach set TinhTrang = @TinhTrang where MaSach = @MaSach";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            records++;
                        }
                    }
                }
                MessageBox.Show($"Đã sửa thành công bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ShowCuonSach_DauSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaDauSach))
            {
                MessageBox.Show("Vui lòng chọn một đầu sách trước khi thêm các cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (con = new SqlConnection(strCon))
            {
                int records = 0;
                con.Open();
                foreach (DataGridViewRow row in dgvCuonSach.Rows)
                {
                    // Bỏ qua các hàng trống hoặc chưa hoàn thành
                    if (row.IsNewRow || row.Cells["MaSach"].Value == null || row.Cells["TinhTrang"].Value == null)
                    {
                        continue;
                    }

                    string maSach = row.Cells["MaSach"].Value.ToString();
                    string tinhTrang = row.Cells["TinhTrang"].Value.ToString();

                    using (SqlCommand cmd = new SqlCommand("ThemCuonSach", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.Parameters.AddWithValue("@MaDauSach", selectedMaDauSach);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            records++;
                        }
                    }
                }
                MessageBox.Show($"Đã thêm thành công {records} bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowCuonSach_DauSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCuonSach.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi được lựa chọn?", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCuonSach.SelectedRows)
                    {
                        string maSach = row.Cells["MaSach"].Value?.ToString() ?? string.Empty;
                        string sql = $"Delete from CuonSach where MaSach = '{maSach}'";
                        DoSQL(sql);
                    }
                    MessageBox.Show($"Đã xóa thành công {dgvCuonSach.SelectedRows.Count} bản ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowCuonSach_DauSach();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi");
            }
        }
    }
}
