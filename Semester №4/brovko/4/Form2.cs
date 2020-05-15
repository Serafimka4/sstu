using System;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nWINDDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.nWINDDataSet.Employees);
            this.productsTableAdapter.Fill(this.nWINDDataSet.Products);
            this.order_DetailsTableAdapter.Fill(this.nWINDDataSet.Order_Details);
            this.ordersTableAdapter.Fill(this.nWINDDataSet.Orders);
            this.customersTableAdapter.Fill(this.nWINDDataSet.Customers);
        }
    }
}
