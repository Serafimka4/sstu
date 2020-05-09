using System;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class MessengesForm : Form
    {
        public MessengesForm()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getMessegesTableAdapter.Fill(this.messengerDBDataSet.GetMesseges, userToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MessengesForm_Load(object sender, EventArgs e)
        {
            Messenger m = (Messenger)MdiParent;
            try
            {
                this.getMessegesTableAdapter.Fill(this.messengerDBDataSet.GetMesseges, m.currUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void GetMessegesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (getMessegesDataGridView.SelectedRows.Count > 0)
            {
                richTextBox1.Text = getMessegesDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
