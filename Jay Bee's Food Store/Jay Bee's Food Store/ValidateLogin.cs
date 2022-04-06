using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Jay_Bee_s_Food_Store
{
    public class ValidateLogin // Class and strings must be public to get and set properties for the object.
    {
        [Required, RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage = "Please enter a valid Email address!")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
