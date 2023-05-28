using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class SaleModel
    {
        public int Id { get; set; }

        public string? CustomerName { get; set; }

        public string[]? Items { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateTime Date { get; set; }

    }
}
