﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
