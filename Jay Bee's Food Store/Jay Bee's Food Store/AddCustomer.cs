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

          String allowedName = @"^.*[a-zA-Z]"; 
          String allowedEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";
          String allowedPword = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$ %^&*-]).{8,}$";

            if (!Regex.IsMatch(firstNameTextBox.Text, allowedName))
            {
               MessageBox.Show("Customer First Name is empty or invalid.");
               return;
            }

            if(!Regex.IsMatch(lastNameTextBox.Text, allowedName))
            {
               MessageBox.Show("Customer Last Name is empty or invalid.");
               return;
            }

            if(!Regex.IsMatch(emailTextBox.Text, allowedEmail))
            {
                MessageBox.Show("Customer Email is empty or invalid.");
                return;
            }
            if(!Regex.IsMatch(pwordTextBox.Text, allowedPword))
            {
                MessageBox.Show("Customer Password is empty or invalid.");
            }

            if (ButtonSubmit.Text == "Submit")
            {
                ValidateAddCustomer customer = new ValidateAddCustomer(firstNameTextBox.Text.Trim(), lastNameTextBox.Text.Trim(), emailTextBox.Text.Trim(), pwordTextBox.Text.Trim());
                CallCustomerDB.addCustomer(customer);
                CustomerClear();
            }

          _parent.CustomerView();
        }

    }
}
