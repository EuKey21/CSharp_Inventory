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

        public CustomerModel? Customer { get; set; }

        public List<ItemModel>? SaleItemList { get; set; }

        public decimal? SalePrice { get; set; }

        public DateTime Date { get; set; }

        public string? Description { get; set; }

    }
}
