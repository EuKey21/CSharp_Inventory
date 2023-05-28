using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class StockModel
    {
        public int Id { get; set; }

        public string? SupplierName { get; set; }

        public string? ItemName { get; set; }

        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }
    }
}
