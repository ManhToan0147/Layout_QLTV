using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_QLTV.Child_UC.QLTacGia
{
    public partial class UC_TacGiaSach : UserControl
    {
        bool isEdit = false;
        public UC_TacGiaSach()
        {
            InitializeComponent();
        }

        private void UC_TacGiaSach_Load(object sender, EventArgs e)
        {
            cboTruong.SelectedIndex = 0;
            cboMode.SelectedIndex = 0;
        }

        private void cboTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
            else
            {
                isEdit = true;
            }
        }
    }
}
