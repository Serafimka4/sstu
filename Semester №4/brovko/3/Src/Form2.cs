using System;
using System.Windows.Forms;

namespace ThirdPractice
{
	public partial class Form2 : Form
	{
		public int counter = 0;
		Form3 f3;
		public Form2()
		{
			InitializeComponent();
		}

		private void WindowMember_Click(object sender, EventArgs e)
		{
			ToolStripItemCollection itemCol = окноToolStripMenuItem.DropDownItems;
			foreach(ToolStripItem item in itemCol)
			{
				if (item.Equals(sender))
				{
					foreach(Form3 f in MdiChildren)
					{
						if (sender.Equals(f.stripItem))
						{
							f.Activate();
						}
					}
				}
			}
		}

		private void createProduct_Click(object sender, EventArgs e)
		{
			Form f1;
			counter++;
			ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the product");
			f1 = new Form3("Name of the product", окноToolStripMenuItem, newItem, this);
			f1.MdiParent = this;
			f1.Show();
			окноToolStripMenuItem.DropDownItems.Add(newItem);
			newItem.Click += WindowMember_Click;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
		}

		private void createHotel_Click(object sender, EventArgs e)
		{
			counter++;
			ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the hostel");
			f3 = new Form3("Name of the hotel", окноToolStripMenuItem, newItem, this);
			f3.MdiParent = this;
			f3.Show();
			окноToolStripMenuItem.DropDownItems.Add(newItem);
			newItem.Click += WindowMember_Click;
		}

		private void organizationCreate_Click(object sender, EventArgs e)
		{
			counter++;
			ToolStripMenuItem newItem = new ToolStripMenuItem(Convert.ToString(counter) + " Name of the organistion");
			f3 = new Form3("Name of the organisation", окноToolStripMenuItem, newItem, this);
			f3.MdiParent = this;
			f3.Show();
			окноToolStripMenuItem.DropDownItems.Add(newItem);
			newItem.Click += WindowMember_Click;
		}

		private void cascad_Click(object sender, EventArgs e)
		{
			foreach (var f in MdiChildren)
			{

				if (f.WindowState == FormWindowState.Minimized)
				{
					f.WindowState = FormWindowState.Normal;
					f.Show();
				}


			}
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mosaic_Click(object sender, EventArgs e)
		{
			foreach (var f in MdiChildren)
			{

				if (f.WindowState == FormWindowState.Minimized)
				{
					f.WindowState = FormWindowState.Normal;
					f.Show();
				}


			}
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void leftEdge_Click(object sender, EventArgs e)
		{
			Form activeChild = this.ActiveMdiChild;
			if (activeChild != null)
			{
				try
				{
					RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
					if (theBox != null)
					{
						theBox.SelectionAlignment = HorizontalAlignment.Left;
					}
				}
				catch
				{
					MessageBox.Show("You need to select a RichTextBox.");
				}
			}
		}

		private void center_Click(object sender, EventArgs e)
		{
			Form activeChild = this.ActiveMdiChild;
			if (activeChild != null)
			{
				try
				{
					RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
					if (theBox != null)
					{
						theBox.SelectionAlignment = HorizontalAlignment.Center;
					}
				}
				catch
				{
					MessageBox.Show("You need to select a RichTextBox.");
				}
			}
		}

		private void rightEdge_Click(object sender, EventArgs e)
		{
			Form activeChild = this.ActiveMdiChild;
			if (activeChild != null)
			{
				try
				{
					RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
					if (theBox != null)
					{
						theBox.SelectionAlignment = HorizontalAlignment.Right;
					}
				}
				catch
				{
					MessageBox.Show("You need to select a RichTextBox.");
				}
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
		}
	}


}
