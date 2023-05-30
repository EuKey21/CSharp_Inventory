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

        public CategoryModel? Category { get; set; }

        public SupplierModel? Supplier { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public string? Description { get; set; }
    }
}
