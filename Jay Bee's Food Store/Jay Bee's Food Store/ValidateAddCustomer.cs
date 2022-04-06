using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Jay_Bee_s_Food_Store
{
    public class ValidateAddCustomer // Auto-implemented properties for pulling info from the database and sending it somewhere in c# 
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Pword { get; set; }

        public ValidateAddCustomer(string firstname, string lastname, string email, string pword)
        {
            FirstName = firstname;    
            LastName = lastname;
            Email = email;
            Pword = pword;
        }

    }
}
