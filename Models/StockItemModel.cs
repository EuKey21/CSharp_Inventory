using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class StockItemModel
    {
        public StockModel? Stock { get; set; }

        public ItemModel? Item { get; set; }

        public int ItemStockQuantity { get; set; }      // TODO : add this quantity to current item quantity

        public decimal? ItemTotalPrice { get { return Item?.UnitPrice * ItemStockQuantity; } }
    }
}
