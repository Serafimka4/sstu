using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nWINDDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.nWINDDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nWINDDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.nWINDDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nWINDDataSet.Order_Details". При необходимости она может быть перемещена или удалена.
            this.order_DetailsTableAdapter.Fill(this.nWINDDataSet.Order_Details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nWINDDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.nWINDDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nWINDDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.nWINDDataSet.Customers);

        }
    }
}
