using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Jay_Bee_s_Food_Store
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public void CustomerClear()
        {
            fNameTextBox.Text = lNameTextBox.Text = emailTextBox.Text = passwordTextBox.Text = String.Empty;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            String allowedName = @"^.*[a-zA-Z]";
            String allowedEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";
            String allowedPword = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$ %^&*-]).{8,}$";

            if (!Regex.IsMatch(fNameTextBox.Text, allowedName))
            {
                MessageBox.Show("Customer First Name is empty or invalid.");
                return;
            }

            if (!Regex.IsMatch(lNameTextBox.Text, allowedName))
            {
                MessageBox.Show("Customer Last Name is empty or invalid.");
                return;
            }

            if (!Regex.IsMatch(emailTextBox.Text, allowedEmail))
            {
                MessageBox.Show("Customer Email is empty or invalid.");
                return;
            }
            if (!Regex.IsMatch(passwordTextBox.Text, allowedPword))
            {
                MessageBox.Show("Customer Password is empty or invalid.");
            }

            if (ButtonSubmit.Text == "Submit")
            {
                ValidateAddCustomer customer = new ValidateAddCustomer(fNameTextBox.Text.Trim(), lNameTextBox.Text.Trim(), emailTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                CallCustomerDB.addCustomer(customer);
                CustomerClear();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = new GroceryStore();
            form1.Show();

            this.Hide();
        }
    }
}
