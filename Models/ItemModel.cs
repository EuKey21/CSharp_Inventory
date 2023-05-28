using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string? ItemName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }
    }
}
