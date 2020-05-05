using System;
using System.Windows.Forms;

namespace ThirdPractice
{
	public partial class Form3 : ThirdPractice.Form1
	{
        	private int counter;
		ToolStripMenuItem MenuItem;
		public ToolStripItem stripItem;
		Form2 f;
		public Form3(String str, ToolStripMenuItem item, ToolStripItem stripItem, Form2 f){
			Name = str;
			InitializeComponent();
			this.Name = str;
			this.lblHead.Text = str;
			this.MenuItem = item;
			this.stripItem = stripItem;
			this.f = f;
			this.counter = f.counter;

		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			f.counter--;
			MenuItem.DropDownItems.Remove(stripItem);
		}
	}
}
