using System;
using System.Windows.Forms;
using BLL;

namespace Lab_5
{
    public partial class ComposeForm : Form
    {
        public ComposeForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Messenger m = (Messenger)MdiParent;
            if(bll.AddMessege(m.currUser, toTxt.Text, subTxt.Text, bodyRTxt.Text) == OperationResult.BadWords)
            {
                errorLbl.Text = "Bad words!!!";
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
