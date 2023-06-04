using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class TradeHistoryViewModel
    {
        private readonly TradeHistoryModel _model;

        public TradeHistoryViewModel(TradeHistoryModel model) => _model = model;
        public TradeHistoryModel GetModel() => _model;

        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
