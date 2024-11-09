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
using System.Text.RegularExpressions;

namespace Layout_QLTV.Child_UC.QLTacGia
{
    public partial class UC_TacGiaSach : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dvDS;
        DataView dvTG;
        DataView dvDSTG;
        bool isEdit = false;
        public UC_TacGiaSach()
        {
            InitializeComponent();
        }

        private void UC_TacGiaSach_Load(object sender, EventArgs e)
        {
            cboTruong.SelectedIndex = 0;
            cboMode.SelectedIndex = 0;
            LoadDauSach();
            LoadTacGia();
            LoadDauSach_TacGia();
        }

        private void LoadDauSach_TacGia()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select * from DauSach_TacGia";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dvDSTG = new DataView(dt);
                dgvDSTG.DataSource = dvDSTG;
            }
        }

        private void LoadTacGia()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select MaTG, TenTG from TacGia";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dvTG = new DataView(dt);
                dgvTacGia.DataSource = dvTG;
            }
        }

        private void LoadDauSach()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select MaDauSach, TenDauSach from DauSach";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dvDS = new DataView(dt);
                dgvDauSach.DataSource = dvDS;
            }
        }

        private void cboTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cboTruong.SelectedIndex == 0)
            {
                txtSearch.PlaceholderText = "Nhập để tìm kiếm tên đầu sách";
            }
            else
            {
                txtSearch.PlaceholderText = "Nhập để tìm kiếm tên tác giả";
            }
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMode.SelectedIndex == 0)
            {
                isEdit = false;
                btnChuyen.Visible = false;
                btnXoa.Visible = false;
            }
            else
            {
                isEdit = true;
                btnChuyen.Visible = true;
                btnXoa.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboTruong.Text == "Đầu sách")
            {
                dvDS.RowFilter = $"TenDauSach like '%{txtSearch.Text}%'";
            }
            else
            {
                dvTG.RowFilter = $"TenTG like '%{txtSearch.Text}%'";
            }
        }

        string selectedMaDS;
        private void dgvDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dvDSTG == null) { return; }

            if (dgvDauSach.SelectedRows.Count > 0)
            {
                int i = dgvDauSach.CurrentRow.Index;
                selectedMaDS = dgvDauSach.Rows[i].Cells[0]?.Value.ToString() ?? "";
                dvDSTG.RowFilter = $"MaDauSach like '{selectedMaDS}'";
            }
            else
            {
                dvDSTG.RowFilter = null;
            }

        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dvDSTG == null) { return; }
            if (!isEdit)
            {
                if (dgvTacGia.SelectedRows.Count > 0)
                {
                    int i = dgvTacGia.CurrentRow.Index;
                    string maTG = dgvTacGia.Rows[i].Cells[0].Value.ToString();
                    dvDSTG.RowFilter = $"MaTG like '{maTG}'";
                }
                else
                {
                    dvDSTG.RowFilter = null;
                }
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaDS))
            {
                MessageBox.Show("Vui lòng chọn một đầu sách", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tác giả", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int count = 0;
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    foreach (DataGridViewRow row in dgvTacGia.SelectedRows)
                    {
                        string maTG = row.Cells[0].Value.ToString();

                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ThemDauSachTacGia";
                        cmd.Parameters.AddWithValue("@MaDauSach", selectedMaDS);
                        cmd.Parameters.AddWithValue("@MaTG", maTG);

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            count++;
                        }
                    }
                }
            }
            LoadDauSach_TacGia();
            dvDSTG.RowFilter = $"MaDauSach like '%{selectedMaDS}%'";
            MessageBox.Show($"Đã thêm mới {count} bản ghi", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSTG.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa các bản ghi đã chọn",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    int count = 0;
                    foreach (DataGridViewRow row in dgvDSTG.SelectedRows)
                    {
                        string maDS = row.Cells[0].Value.ToString();
                        string maTG = row.Cells[1].Value.ToString();

                        using (con = new SqlConnection(strCon))
                        {
                            con.Open();
                            string sql = $"Delete from DauSach_TacGia where MaDauSach = '{maDS}' and MaTG = '{maTG}'";

                            cmd = new SqlCommand(sql, con);
                            int kq = cmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                count++;
                            }
                        }
                    }
                    MessageBox.Show($"Đã xoá {count} bản ghi", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDauSach_TacGia();
                    if (!string.IsNullOrEmpty(selectedMaDS))
                    {
                        dvDSTG.RowFilter = $"MaDauSach like '%{selectedMaDS}%'";
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn bản ghi để xóa", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
