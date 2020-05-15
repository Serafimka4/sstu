using System;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nWINDDataSet);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.nWINDDataSet.Customers);
            this.productsTableAdapter.Fill(this.nWINDDataSet.Products);
            this.order_DetailsTableAdapter.Fill(this.nWINDDataSet.Order_Details);
            this.ordersTableAdapter.Fill(this.nWINDDataSet.Orders);
            this.employeesTableAdapter.Fill(this.nWINDDataSet.Employees);
        }
    }
}
