using Layout_QLTV.Child_UC;
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
    public partial class UC_QuanLySach_Ribbon : UserControl
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public UC_QuanLySach_Ribbon()
        {
            InitializeComponent();
            btnChiTietSach.Checked = true;
            UC_ChiTietSach uc = new UC_ChiTietSach();
            addUserControl(uc);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            UC_ChiTietSach uc = new UC_ChiTietSach();
            addUserControl(uc);
        }

        private void btnDauSach_Click(object sender, EventArgs e)
        {
            UC_DauSach uc = new UC_DauSach();
            addUserControl(uc);
        }
    }
}
