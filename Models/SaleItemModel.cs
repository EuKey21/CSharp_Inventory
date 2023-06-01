using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class SaleItemModel
    {
        public SaleModel? Sale { get; set; }

        public ItemModel? Item { get; set; }

        public int ItemSaleQuantity { get; set; }

        public decimal? ItemTotalPrice { get { return Item?.UnitPrice * ItemSaleQuantity; } }
    }
}
