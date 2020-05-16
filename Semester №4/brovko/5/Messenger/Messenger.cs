using System;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Messenger : Form
    {
        public bool isLegitUser;
        public string currUser;
        private MessengesForm messenges;

        public Messenger()
        {
            InitializeComponent();
            currUser = "";
            isLegitUser = false;
            logoutBtn.Click += LegitUserChangeHandler;
        }

        private void LegitUserChangeHandler(object sender, EventArgs e)
        {
            if (isLegitUser)
            {
                isLegitUser = false;
                composeBtn.Enabled = false;
                checkBtn.Enabled = false;
                closeMsgBoxBtn.Enabled = false;
                logoutBtn.Enabled = false;
            }
            else
            {
                isLegitUser = true;
                composeBtn.Enabled = true;
                checkBtn.Enabled = true;
                closeMsgBoxBtn.Enabled = true;
                logoutBtn.Enabled = true;
            }
        }

        public void LegitUserChangeHandler()
        {
            if (isLegitUser)
            {
                isLegitUser = false;
                composeBtn.Enabled = false;
                checkBtn.Enabled = false;
                closeMsgBoxBtn.Enabled = false;
                logoutBtn.Enabled = false;
            }
            else
            {
                isLegitUser = true;
                composeBtn.Enabled = true;
                checkBtn.Enabled = true;
                closeMsgBoxBtn.Enabled = true;
                logoutBtn.Enabled = true;
            }
        }

        private void Messenger_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.MdiParent = this;
            lf.Login += LegitUserChangeHandler;
            lf.Login += OpenMessegesForm;

            lf.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            currUser = "";

            LoginForm lf = new LoginForm();
            lf.MdiParent = this;
            lf.Login += LegitUserChangeHandler;
            lf.Login += OpenMessegesForm;
            lf.Show();
        }

        private void ComposeBtn_Click(object sender, EventArgs e)
        {
            ComposeForm compose = new ComposeForm();
            compose.MdiParent = this;
            compose.Show();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            messenges = new MessengesForm();
            messenges.MdiParent = this;
            messenges.Show();
        }

        private void CloseMsgBoxBtn_Click(object sender, EventArgs e)
        {
            messenges.Close();
        }

        public void OpenMessegesForm()
        {
            messenges = new MessengesForm();
            messenges.MdiParent = this;
            messenges.Show();
        }
    }
}
