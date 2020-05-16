using BLL;
using System;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public event Action Login;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string password = Bll.GetPassword(userNameTxt.Text);

            if (password.Equals(passwordTxt.Text))
            {
                Messenger m = (Messenger)MdiParent;
                m.currUser = userNameTxt.Text;
                Login?.Invoke();
                Close();
            }
        }

        private void SungUpBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.MdiParent = MdiParent;
            rf.Show();
            Close();
        }
    }
}
