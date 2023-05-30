using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class StockItemViewModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockQuantity { get; set; }

        public decimal? TotalPrice { get ; set; }
        

        private readonly StockItemModel _model;

        public StockItemViewModel(StockItemModel model) => _model = model;

        public StockItemModel GetModel() => _model;
    }
}
