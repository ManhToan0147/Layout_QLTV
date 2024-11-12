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

namespace Layout_QLTV.Child_UC.QLDocGia
{
    public partial class UC_QLDocGia : UserControl
    {
        string strCon = @"Data Source=DESKTOP-HPGDAGQ\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataView dv;
        public UC_QLDocGia()
        {
            InitializeComponent();
        }

        private void UC_QLDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            cboTruong.SelectedIndex = 0;
        }

        private void LoadDocGia()
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select * from DocGia";
                adapter = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dv = new DataView(dt);
                dgvDocGia.DataSource = dv;
                dgvDocGia.Columns["HinhAnh"].HeaderText = "Hình ảnh";
            }
        }

        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            NapCT();
        }

        string selectedMaTheMuon;
        private void NapCT()
        {
            if (dgvDocGia.CurrentRow != null && dgvDocGia.CurrentRow.Index >= 0)
            {
                //Xu ly chu
                int i = dgvDocGia.CurrentRow.Index;
                selectedMaTheMuon = dgvDocGia.Rows[i].Cells["MaTheMuon"]?.Value.ToString() ?? string.Empty;
                txtMaTheMuon.Text = selectedMaTheMuon;
                txtMaTheMuon.Enabled = string.IsNullOrEmpty(txtMaTheMuon.Text);

                txtHoTen.Text = dgvDocGia.Rows[i].Cells["HoTen"].Value.ToString();
                txtNgheNghiep.Text = dgvDocGia.Rows[i].Cells["NgheNghiep"].Value.ToString();

                dateNgayCap.Value = dgvDocGia.Rows[i].Cells["NgayCapThe"].Value is DBNull ? DateTime.Now : (DateTime)dgvDocGia.Rows[i].Cells["NgayCapThe"].Value;
                dateNgayHan.Value = dgvDocGia.Rows[i].Cells["NgayHanThe"].Value is DBNull ? DateTime.Now : (DateTime)dgvDocGia.Rows[i].Cells["NgayHanThe"].Value;

                LoadImage(selectedMaTheMuon);
            }

        }

        private void LoadImage(string maTheMuon)
        {
            using (con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "Select HinhAnh from DocGia where MaTheMuon = @MaTheMuon";
                using (cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaTheMuon", maTheMuon);

                    object imageData = cmd.ExecuteScalar();
                    if (imageData != null && imageData != DBNull.Value)
                    {
                        // Có dữ liệu ảnh, chuyển đổi từ byte array sang Image
                        byte[] bytes = (byte[])imageData;
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            picAvatar.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picAvatar.Image = Image.FromFile("Resources\\Images\\avatar_default.png");
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFile.Title = "Chọn ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(openFile.FileName);
            }
        }
        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return null; // Hoặc trả về một mảng byte mặc định nếu cần
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Image img = new Bitmap(pictureBox.Image);
                img.Save(ms, pictureBox.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaTheMuon))
            {
                MessageBox.Show("Chưa chọn bản ghi để sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                byte[] imageData = ImageToByteArray(picAvatar);
                string ngayCap = dateNgayCap.Value.ToString("yyyy-MM-dd");
                string ngayHan = dateNgayHan.Value.ToString("yyyy-MM-dd");

                string sql = "UPDATE DocGia SET HoTen = @HoTen, NgheNghiep = @NgheNghiep, " +
                             "NgayCapThe = @NgayCapThe, NgayHanThe = @NgayHanThe, HinhAnh = @HinhAnh " +
                             "WHERE MaTheMuon = @MaTheMuon";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Thêm các tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgheNghiep", txtNgheNghiep.Text);
                    cmd.Parameters.AddWithValue("@NgayCapThe", ngayCap);
                    cmd.Parameters.AddWithValue("@NgayHanThe", ngayHan);

                    // Xử lý ảnh (nếu không có ảnh thì gán null)
                    if (imageData != null && imageData.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@HinhAnh", imageData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@MaTheMuon", selectedMaTheMuon);

                    // Thực thi câu lệnh
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadDocGia();
        }

        private void cboTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTruong.SelectedIndex == 0)
            {
                txtSearch.PlaceholderText = "Nhập để tìm kiếm tên độc giả";
            }
            else
            {
                txtSearch.PlaceholderText = "Nhập để tìm kiếm theo mã thẻ mượn";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboTruong.Text == "Tên độc giả")
            {
                dv.RowFilter = $"HoTen like '%{txtSearch.Text}%'";
            }
            else
            {
                dv.RowFilter = $"MaTheMuon like '%{txtSearch.Text}%'";
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

            txtMaTheMuon.Text = "";
            txtMaTheMuon.Enabled = string.IsNullOrEmpty(txtMaTheMuon.Text);

            txtHoTen.Text = "";
            txtNgheNghiep.Text = "";
            dateNgayCap.Value = DateTime.Now;
            dateNgayHan.Value = DateTime.Now;
            txtMaTheMuon.Focus();
            picAvatar.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    byte[] imageData = ImageToByteArray(picAvatar);
                    string ngayCap = dateNgayCap.Value.ToString("yyyy-MM-dd");
                    string ngayHan = dateNgayHan.Value.ToString("yyyy-MM-dd");

                    string sql = "Insert into DocGia " +
                    "Values (@MaTheMuon, @HoTen, @HinhAnh, @NgheNghiep, @NgayCapThe, @NgayHanThe)";
                    using (cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaTheMuon", txtMaTheMuon.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgheNghiep", txtNgheNghiep.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayCapThe", ngayCap);
                        cmd.Parameters.AddWithValue("@NgayHanThe", ngayHan);

                        cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = imageData ?? (object)DBNull.Value;

                        // Thực thi câu lệnh

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadDocGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaTheMuon))
            {
                MessageBox.Show("Chưa chọn bản ghi để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn và các bản ghi khác liên quan?",
                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                using (con = new SqlConnection(strCon))
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    string sql1 = $"Delete from PhieuPhat where MaTheMuon = {selectedMaTheMuon}";
                }
            }
        }
    }
}
