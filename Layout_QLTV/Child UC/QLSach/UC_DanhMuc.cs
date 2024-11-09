using Guna.UI2.WinForms;
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

namespace Layout_QLTV.Child_UC
{
    public partial class UC_DanhMuc : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        bool addNewFlag = false;
        public UC_DanhMuc()
        {
            InitializeComponent();
        }

        private void UC_DanhMuc_Load(object sender, EventArgs e)
        {
            dgvLoaiSach.DataSource = LoadData("LoaiSach");
            dgvChuDe.DataSource = LoadData("ChuDe");
            dgvNXB.DataSource = LoadData("NXB");
            dgvKhoSach.DataSource = LoadData("KhoSach");
        }

        private DataTable LoadData(string table)
        {
            DataTable dt = new DataTable();

            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = $"SELECT * FROM {table}";
                using (adapter = new SqlDataAdapter(sql, con))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private void NapCT(DataGridView dgv, Guna2TextBox t1, Guna2TextBox t2)
        {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                int i = dgv.CurrentRow.Index;
                t1.Text = dgv.Rows[i].Cells[0].Value.ToString();
                t2.Text = dgv.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void dgvLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            NapCT(dgvLoaiSach, txtMaLoaiSach, txtTenLoaiSach);
        }

        private void dgvChuDe_SelectionChanged(object sender, EventArgs e)
        {
            NapCT(dgvChuDe, txtMaChuDe, txtTenChuDe);
        }

        private void dgvNXB_SelectionChanged(object sender, EventArgs e)
        {
            NapCT(dgvNXB, txtMaNXB, txtTenNXB);
        }

        private void dgvKhoSach_SelectionChanged(object sender, EventArgs e)
        {
            NapCT(dgvKhoSach, txtMaKho, txtTenKho);
        }

        private void dgvLoaiSach_SelectionChanged_1(object sender, EventArgs e)
        {
            NapCT(dgvLoaiSach, txtMaLoaiSach, txtTenLoaiSach);
        }

        private void DoSQL(string sql)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    int rs = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi thuc thi " + ex.Message);
            }

        }

        private void TaoMoi(List<Guna2TextBox> lst)
        {
            foreach (var t in lst)
            {
                t.Text = "";
            }
        }

        private void btn1TaoMoi_Click(object sender, EventArgs e)
        {
            List<Guna2TextBox> lst = new List<Guna2TextBox>() { txtMaLoaiSach, txtTenLoaiSach };
            TaoMoi(lst);
        }

        private void btn2TaoMoi_Click(object sender, EventArgs e)
        {
            List<Guna2TextBox> lst = new List<Guna2TextBox>() { txtMaChuDe, txtTenChuDe };
            TaoMoi(lst);
        }

        private void btn3TaoMoi_Click(object sender, EventArgs e)
        {
            List<Guna2TextBox> lst = new List<Guna2TextBox>() { txtMaNXB, txtTenNXB };
            TaoMoi(lst);
        }

        private void btn4TaoMoi_Click(object sender, EventArgs e)
        {
            List<Guna2TextBox> lst = new List<Guna2TextBox>() { txtMaKho, txtTenKho };
            TaoMoi(lst);
        }

        private void Them(string table, string Ma, string Ten)
        {
            if (string.IsNullOrEmpty(Ma))
            {
                MessageBox.Show("Mã không được để trống. Vui lòng nhập giá trị cho khóa chính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"Insert into {table} values ('{Ma}', N'{Ten}')";
            DoSQL(sql);
            MessageBox.Show($"Đã thêm thành công bản ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Sua(string table, Dictionary<string, string> dict)
        {
            var primaryKey = dict.ElementAt(0);
            var updateField = dict.ElementAt(1);

            string sql = $"UPDATE {table} SET {updateField.Key} = N'{updateField.Value}' WHERE {primaryKey.Key} = '{primaryKey.Value}'";
            DoSQL(sql);
            MessageBox.Show($"Đã sửa thành công bản ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa(DataGridView dgv, string table, string ma)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi được lựa chọn?", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv.SelectedRows)
                    {
                        string selectedMa = row.Cells[0].Value?.ToString() ?? string.Empty;
                        string sql = $"Delete from {table} where {ma} = '{selectedMa}'";
                        DoSQL(sql);
                    }
                    MessageBox.Show($"Đã xóa {dgv.SelectedRows.Count} bản ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bản ghi");
            }
        }

        private void btn1Them_Click(object sender, EventArgs e)
        {
            Them("LoaiSach", txtMaLoaiSach.Text, txtTenLoaiSach.Text);
            dgvLoaiSach.DataSource = LoadData("LoaiSach");
        }

        private void btn1Xoa_Click(object sender, EventArgs e)
        {
            Xoa(dgvLoaiSach, "LoaiSach", "MaLoaiSach");
            dgvLoaiSach.DataSource = LoadData("LoaiSach");
        }

        private void btn1Sua_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>()
            {
                {"MaLoaiSach",  txtMaLoaiSach.Text},
                {"TenLoaiSach",  txtTenLoaiSach.Text}
            };
            Sua("LoaiSach", dict);
            dgvLoaiSach.DataSource = LoadData("LoaiSach");
        }

        private void btn2Them_Click(object sender, EventArgs e)
        {
            Them("ChuDe", txtMaChuDe.Text, txtTenChuDe.Text);
            dgvChuDe.DataSource = LoadData("ChuDe");
        }

        private void btn2Xoa_Click(object sender, EventArgs e)
        {
            Xoa(dgvChuDe, "ChuDe", "MaChuDe");
            dgvChuDe.DataSource = LoadData("ChuDe");
        }

        private void btn2Sua_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>()
            {
                {"MaChuDe",  txtMaChuDe.Text},
                {"TenChuDe",  txtTenChuDe.Text}
            };
            Sua("ChuDe", dict);
            dgvChuDe.DataSource = LoadData("ChuDe");
        }

        private void btn3Them_Click(object sender, EventArgs e)
        {
            Them("NXB", txtMaNXB.Text, txtTenNXB.Text);
            dgvNXB.DataSource = LoadData("NXB");
        }

        private void btn3Xoa_Click(object sender, EventArgs e)
        {
            Xoa(dgvNXB, "NXB", "MaNXB");
            dgvNXB.DataSource = LoadData("NXB");
        }

        private void btn3Sua_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>()
            {
                {"MaNXB",  txtMaNXB.Text},
                {"TenNXB",  txtTenNXB.Text}
            };
            Sua("NXB", dict);
            dgvNXB.DataSource = LoadData("NXB");
        }

        private void btn4Them_Click(object sender, EventArgs e)
        {
            Them("KhoSach", txtMaKho.Text, txtTenKho.Text);
            dgvKhoSach.DataSource = LoadData("KhoSach");
        }

        private void btn4Xoa_Click(object sender, EventArgs e)
        {
            Xoa(dgvKhoSach, "KhoSach", "MaKho");
            dgvKhoSach.DataSource = LoadData("KhoSach");
        }

        private void btn4Sua_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>()
            {
                {"MaKho", txtMaKho.Text },
                {"TenKho", txtTenKho.Text}
            };
            Sua("KhoSach", dict); 
            dgvKhoSach.DataSource = LoadData("KhoSach");
        }
    }
}
