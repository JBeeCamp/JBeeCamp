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
    internal partial class GroceryStore : Form
    {
        internal GroceryStore()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Login();
            form2.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Register();
            form3.ShowDialog();
        }

        private void GroceryStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
