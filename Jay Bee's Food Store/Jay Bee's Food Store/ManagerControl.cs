using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_Bee_s_Food_Store
{
    public partial class ManagerControl : Form
    {

        public ManagerControl()
        {
            InitializeComponent();
        }

        public void CustomerView()
        {
            CallCustomerDB.CustomerDisplay("SELECT CustomerID, FirstName, LastName, Email, Pword FROM dbo.Customer", dataGridCustomerView);
        }


        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            var form7 = new AddCustomer(this);
            form7.CustomerClear();
            form7.ShowDialog();
        }

        private void ManagerControl_Shown(object sender, EventArgs e)
        {
            CustomerView();
        }

        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            CallCustomerDB.CustomerDisplay("SELECT CustomerID, FirstName, LastName, Email, Pword FROM dbo.Customer WHERE FirstName LIKE '%" + textBoxSearchCustomer.Text + "%'", dataGridCustomerView);
        }

        private void ManagerControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project0DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.project0DataSet.Customer);

        }

        private void dataGridCustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Do you want to delete this customer record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CallCustomerDB.deleteCustomer(dataGridCustomerView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    CustomerView();
                }
                return;
            }
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            var form8 = new ViewOrders();
            form8.ShowDialog();
        }

        private void ManagerControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = new GroceryStore();
            form1.Show();

            this.Hide();
        }
    }
}
