using Layout_QLTV.Child_UC.QLTacGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_QLTV.Ribbon_trên_sidebar
{
    public partial class UC_QLTacGia_Ribbon : UserControl
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public UC_QLTacGia_Ribbon()
        {
            InitializeComponent();
        }

        private void UC_QLTacGia_Ribbon_Load(object sender, EventArgs e)
        {
            btnTacGia.Checked = true;
            var uc = new UC_TacGia();
            addUserControl(uc);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            var uc = new UC_TacGia();
            addUserControl(uc);
        }

        private void btnTacGiaSach_Click(object sender, EventArgs e)
        {
            var uc = new UC_TacGiaSach();
            addUserControl(uc);
        }
    }
}
