using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.Models
{
    public class TradeHistoryModel
    {
        private StockModel? stock;
        private SaleModel? sale;
        private decimal total;

        public int Id { get; set; }

        public StockModel Stock
        {
            get => stock;
            set 
            { 
                stock = value; 
                sale = null; 
                UpdateTotal();
            }
        }

        public SaleModel Sale
        {
            get => sale;
            set 
            { 
                stock = null; 
                sale = value;
                UpdateTotal();
            }
        }

        public decimal Total 
        { 
            get => total;
            set 
            {
                total = value;
                UpdateTotal(); 
            }
        }

        public DateTime Date { get; set; }

        private void UpdateTotal()
        {
            // Total from sale
            if(stock == null)
            {
                total *= 1;
            }
            // Total from stock
            else if (sale == null)
            {
                total *= -1;
            }
        }
    }
}
