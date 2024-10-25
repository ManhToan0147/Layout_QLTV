using Custom_Tabs;
using Dental_Application;
using Layout_QLTV;

namespace Layout
{
    public partial class frmLayout : Form
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public frmLayout()
        {
            InitializeComponent();
        }

        private Form currentForm = null;
        private void btnSignInOpen_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            frmSignIn f = new frmSignIn();
            currentForm = f;
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staThoiGian.Text = System.DateTime.Now.ToString();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn f = new frmSignIn();
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            UC_Inbox uc = new UC_Inbox();
            addUserControl(uc);
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            UC_Sent uc = new UC_Sent();
            addUserControl(uc);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UC_Settingcs uc = new UC_Settingcs();
            addUserControl(uc);
        }

        private void btnNothing_Click(object sender, EventArgs e)
        {
            UC_Nothing uc = new UC_Nothing();
            addUserControl(uc);
        }
    }
}
