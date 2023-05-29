using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class PersonModel
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

    }
}
