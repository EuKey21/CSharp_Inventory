using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class SaleItemViewModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }

        public int SaleQuantity { get; set; }

        public decimal? TotalPrice { get; set; }


        private readonly SaleItemModel _model;

        // Constructor
        public SaleItemViewModel(SaleItemModel model) => _model = model;

        public SaleItemModel GetModel() => _model;
    }
}
