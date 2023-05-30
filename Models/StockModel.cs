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

        public SupplierModel? Supplier { get; set; }

        public List<StockItemModel>? StockItemList { get; set; }

        public decimal? StockPrice { get; set; }

        public DateTime Date { get; set; }

        public string? Description { get; set; }
        
    }
}
