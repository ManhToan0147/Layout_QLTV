using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_QLTV
{
    public partial class ChiTietSach : Form
    {
        public ChiTietSach()
        {
            InitializeComponent();
        }

        private void ChiTietSach_Load(object sender, EventArgs e)
        {

        }

        public void LoadBookDetails(DataGridViewRow row)
        {
            txtMaDauSach.Text = row.Cells["MaDauSach"].Value.ToString();
            txtTenDauSach.Text = row.Cells["TenDauSach"].Value.ToString();
            txtTenTacGia.Text = row.Cells["TenTacGia"].Value.ToString();
            txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
            txtGiaBia.Text = row.Cells["GiaBia"].Value.ToString();
            txtSoTrang.Text = row.Cells["SoTrang"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txtLoaiSach.Text = row.Cells["TenLoaiSach"].Value.ToString();
            txtChuDe.Text = row.Cells["TenChuDe"].Value.ToString();
            txtNXB.Text = row.Cells["TenNXB"].Value.ToString();
            txtKhoSach.Text = row.Cells["TenKho"].Value.ToString();
        }
    }
}
