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
using System.Net.Http.Headers;

namespace Layout_QLTV.Child_UC.QLTacGia
{
    public partial class UC_TacGia : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        public UC_TacGia()
        {
            InitializeComponent();
        }

        private void UC_TacGia_Load(object sender, EventArgs e)
        {
            LoadTacGia();
        }

        private void LoadTacGia()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select * from TacGia";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            dv = new DataView(dt);
            dgvTacGia.DataSource = dv;
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }

        private void NapCT()
        {
            if (dgvTacGia.CurrentRow != null && dgvTacGia.CurrentRow.Index >= 0)
            {
                int i = dgvTacGia.CurrentRow.Index;
                txtMaTacGia.Text = dgvTacGia.Rows[i].Cells["MaTG"].Value.ToString();
                txtMaTacGia.Enabled = string.IsNullOrEmpty(txtMaTacGia.Text);

                txtTenTacGia.Text = dgvTacGia.Rows[i].Cells["TenTG"].Value.ToString();
                cboGioiTinh.Text = dgvTacGia.Rows[i].Cells["GioiTinh"].Value.ToString();
                txtNamSinh.Text = dgvTacGia.Rows[i].Cells["NamSinh"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dv.RowFilter = $"TenTG LIKE '%{search}%'";
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = true;
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            txtNamSinh.Text = "";

            txtMaTacGia.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maTG = txtMaTacGia.Text.Trim();
                string tenTG = txtTenTacGia.Text.Trim();
                string gioiTinh = cboGioiTinh.Text.Trim();
                string namSinh = txtNamSinh.Text.Trim();

                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    string query = "INSERT INTO TacGia (MaTG, TenTG, GioiTinh, NamSinh) VALUES (@MaTG, @TenTG, @GioiTinh, @NamSinh)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaTG", maTG);
                        cmd.Parameters.AddWithValue("@TenTG", tenTG);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NamSinh", namSinh);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Đã thêm thành công bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTacGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi them du lieu " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa các bản ghi đã chọn và các bản ghi khác liên quan?",
                    "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;

                            int deletedCount = 0;

                            foreach (DataGridViewRow row in dgvTacGia.SelectedRows)
                            {
                                string maTG = row.Cells["MaTG"].Value.ToString();

                                string sql1 = $"DELETE FROM DauSach_TacGia WHERE MaTG = '{maTG}';";
                                string sql2 = $"DELETE FROM TacGia WHERE MaTG = '{maTG}';";

                                // Thực hiện xóa trong bảng DauSach_TacGia
                                cmd.CommandText = sql1;
                                cmd.ExecuteNonQuery();

                                // Thực hiện xóa trong bảng TacGia
                                cmd.CommandText = sql2;
                                int kq = cmd.ExecuteNonQuery();

                                if (kq > 0)
                                {
                                    deletedCount++;
                                }
                            }

                            MessageBox.Show($"Đã xóa {deletedCount} bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LoadTacGia();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            string maTG = txtMaTacGia.Text.Trim();

            if (string.IsNullOrEmpty(maTG))
            {
                MessageBox.Show("Vui lòng chọn một ô để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTG = txtTenTacGia.Text.Trim();
            string gioiTinh = cboGioiTinh.Text.Trim();
            string namSinh = txtNamSinh.Text.Trim();

            string sql = $"Update TacGia set TenTG = N'{tenTG}', " +
                $"GioiTinh = N'{gioiTinh}', " +
                $"NamSinh = {namSinh} where MaTG = '{maTG}'";

            using (con = new SqlConnection(strCon))
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTacGia(); 
                } 
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
