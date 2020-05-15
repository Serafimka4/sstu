using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public int childrenCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
        }

        private void WindowMember_Click(object sender, EventArgs e)
        {
            ToolStripItemCollection items = windowToolStripMenuItem.DropDownItems;

            foreach (ToolStripItem i in items)
                if (i.Equals(sender))
                    foreach (InheritedPamphletForm f in MdiChildren)
                        if (sender.Equals(f.stripItem))
                            f.Activate();
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            CreateChildForm("Name of the product", " Name of the product");
        }

        private void CreateHotel_Click(object sender, EventArgs e)
        {
            CreateChildForm("Name of the hotel", " Name of the hotel");
        }

        private void OrganizationCreate_Click(object sender, EventArgs e)
        {
            CreateChildForm("Name of the organisation", " Name of the organisation");
        }

        private void CreateChildForm(string formName, string windowTitle)
        {
            ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(++childrenCount) + windowTitle);

            Form f = new InheritedPamphletForm(formName, windowToolStripMenuItem, newItem, this)
            {
                MdiParent = this
            };

            f.Show();

            windowToolStripMenuItem.DropDownItems.Add(newItem);
            newItem.Click += WindowMember_Click;
        }

        private void Cascad_Click(object sender, EventArgs e)
        {
            ShowAllWindows();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void Mosaic_Click(object sender, EventArgs e)
        {
            ShowAllWindows();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ShowAllWindows()
        {
            foreach (var f in MdiChildren)
            {
                if (f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }
            }
        }

        private void AlignLeft_Click(object sender, EventArgs e)
        {
            AlignRichTextBox(HorizontalAlignment.Left);
        }

        private void AlignCenter_Click(object sender, EventArgs e)
        {
            AlignRichTextBox(HorizontalAlignment.Center);
        }

        private void AlignRight_Click(object sender, EventArgs e)
        {
            AlignRichTextBox(HorizontalAlignment.Right);
        }

        private void AlignRichTextBox(HorizontalAlignment alignment)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {
                try
                {
                    RichTextBox box = (RichTextBox)activeChild.ActiveControl;

                    if (box != null)
                        box.SelectionAlignment = alignment;
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}