using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Jay_Bee_s_Food_Store
{
    class CallCustomerDB //This class file is for calling the database for Customers.
    {
        public static SqlConnection GetConnection() //Opening connection
        {
            string connectionString = File.ReadAllText(@"/Revature/JBeeCamp/Project0/ProjectSQLServer.txt"); // Reading connection string

            SqlConnection Connecting = new SqlConnection(connectionString);
            try // Try to catch an SqlException
            {
                Connecting.Open(); // Database Connection has been opened
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Uh oh! \n" + ex.Message, "SQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Shows an error window
            }
            return Connecting; // Return the connection value
        }

        public static void addCustomer(ValidateAddCustomer customer) // Pulls the auto-implemented properties in ValidateAddCustomer.
        {
            string data = "INSERT INTO dbo.Customer (FirstName, LastName, Email, Pword) VALUES (@CustomerFirstName, @CustomerLastName, @CustomerEmail, @CustomerPword)"; //Declared Query language string
            SqlConnection connection = GetConnection(); // Goes to my connection method for connecting to database
            SqlCommand command = new SqlCommand(data, connection); // Declares object command for use in CommandType

            command.CommandType = CommandType.Text; // Declares CommandType to read the text inside of the textbox to be read as a SQL Data Type.
            command.Parameters.Add("@CustomerFirstName", SqlDbType.VarChar).Value = customer.FirstName; 
            command.Parameters.Add("@CustomerLastName", SqlDbType.VarChar).Value = customer.LastName;
            command.Parameters.Add("@CustomerEmail", SqlDbType.VarChar).Value = customer.Email;
            command.Parameters.Add("@CustomerPword", SqlDbType.VarChar).Value = customer.Pword;
            try // Try to catch an SqlException
            {
                command.ExecuteNonQuery();  // Executes the SqlCommand parameters
                MessageBox.Show("Customer Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Shows success window

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to Add Customer! \n" + ex.Message, "SQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Shows an error window
            }
            connection.Close(); // Closes the connection
        }

        public static void deleteCustomer(string id)
        {
            string data = "DELETE FROM dbo.Customer WHERE CustomerID = @CustomerID"; //Declared Query language string
            SqlConnection connection = GetConnection(); // Goes to my connection method for connecting to database
            SqlCommand command = new SqlCommand(data, connection); // Declares object command for use in CommandType

            command.CommandType = CommandType.Text; // Declares CommandType to read the text inside of the textbox to be read as a SQL Data Type.
            command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = id;

            try
            {
                command.ExecuteNonQuery(); // Executes the SqlCommand parameters
                MessageBox.Show("Customer Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Shows success window
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to Delete Customer! \n" + ex.Message, "SQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Shows an error window
            }
            connection.Close(); // Closes the connection
        }

        public static void CustomerDisplay(string queryData, DataGridView gridView)
        {
            string data = queryData; //Declares a string from the method parameter
            SqlConnection connection = GetConnection(); // Goes to my connection method for connecting to database
            SqlCommand command = new SqlCommand(data, connection); // Declares object command for use in CommandType

            SqlDataAdapter adapter = new SqlDataAdapter(command); // Declaring object adapter from SqlDataAdapter to be used in DataGridViewer
            DataTable table = new DataTable(); // Declares DataTable object
            adapter.Fill(table); // .Fill by refreshing the table with data gathered from database in the specified ranges

            gridView.DataSource = table; // Looks at the get, set values and puts them in the DataGridViewer
            connection.Close(); // Closes the connection
        }
    }
}
