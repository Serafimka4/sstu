using System.Windows.Forms;

namespace Lab_3
{
    public partial class InheritedPamphletForm : PamphletForm
    {
        private ToolStripMenuItem menuItem;
        public ToolStripItem stripItem;
        private MainForm f;

        public InheritedPamphletForm(string name, ToolStripMenuItem item, ToolStripItem stripItem, MainForm f)
        {
            InitializeComponent();

            this.Name = name;
            this.lblHead.Text = name;
            this.menuItem = item;
            this.stripItem = stripItem;
            this.f = f;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.childrenCount--;
            menuItem.DropDownItems.Remove(stripItem);
        }
    }
}
