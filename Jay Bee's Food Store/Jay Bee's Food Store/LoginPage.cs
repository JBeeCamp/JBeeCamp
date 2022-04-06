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

namespace Jay_Bee_s_Food_Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            validateLoginBindingSource.DataSource = new ValidateLogin();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = new GroceryStore();
            form1.Show();

            this.Hide();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            validateLoginBindingSource.EndEdit();
            ValidateLogin validatelogin = validateLoginBindingSource.Current as ValidateLogin;
            if (validatelogin != null)
            {
                ValidationContext context = new ValidationContext(validatelogin, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(validatelogin, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }
            var form6 = new ManagerControl();
            form6.Show();

            this.Hide();
        }

    }
}
