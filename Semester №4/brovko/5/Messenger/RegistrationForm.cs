using BLL;
using System;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            OperationResult or = Bll.AddUser(userNameTxt.Text, passwordTxt.Text, fullNameTxt.Text);
            if (or == OperationResult.UserExists)
            {
                errorLbl.Text = "User with this user name is exist";
            }
            if (or == OperationResult.OK)
            {
                LoginForm lf = new LoginForm();
                lf.MdiParent = this.MdiParent;
                Messenger m = (Messenger)MdiParent;
                lf.Login += m.LegitUserChangeHandler;
                lf.Login += m.OpenMessegesForm;
                lf.Show();
                Close();
            }
        }
    }
}
