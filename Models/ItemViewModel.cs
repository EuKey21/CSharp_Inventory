using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class ItemViewModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal UnitPrice { get; set; }   


        private readonly ItemModel _model;

        public ItemViewModel(ItemModel model) => _model = model;

        public ItemModel GetModel() => _model;
    }
}
