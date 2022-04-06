using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jay_Bee_s_Food_Store
{
    public partial class AddCustomer : Form
    {
        private readonly ManagerControl _parent;
        public AddCustomer(ManagerControl parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void CustomerClear()
        {
            firstNameTextBox.Text = lastNameTextBox.Text = emailTextBox.Text = pwordTextBox.Text = String.Empty; // Clears all textboxes
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form6 = new ManagerControl(); // Declares a var variable to act like the method ManagerControl()
            form6.Show(); // Shows AddCustomer form

            this.Hide(); // Hides current form
        }


        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

          String allowedName = @"^.*[a-zA-Z]"; // Regex expression that the textboxes have to include with these patterns.
          String allowedEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"; // Regex expression that the textbox must include these patterns.

            if (!Regex.IsMatch(firstNameTextBox.Text, allowedName)) // Must match this expression.
            {
               MessageBox.Show("Customer First Name is empty or invalid.");
               return;
            }

            if(!Regex.IsMatch(lastNameTextBox.Text, allowedName)) // Must match this expression.
            {
               MessageBox.Show("Customer Last Name is empty or invalid.");
               return;
            }

            if(!Regex.IsMatch(emailTextBox.Text, allowedEmail)) // Must match this expression.
            {
                MessageBox.Show("Customer Email is empty or invalid.");
                return;
            }
 
            if (ButtonSubmit.Text == "Submit") // When clicking the button that has "Submit", do this.
            {
                ValidateAddCustomer customer = new ValidateAddCustomer(firstNameTextBox.Text.Trim(), lastNameTextBox.Text.Trim(), emailTextBox.Text.Trim(), pwordTextBox.Text.Trim());
                CallCustomerDB.addCustomer(customer);
                CustomerClear();
            }

          _parent.CustomerView(); // Back to ManagerControl
        }

    }
}
