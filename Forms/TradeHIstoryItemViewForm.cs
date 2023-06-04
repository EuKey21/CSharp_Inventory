using CSharp_Inventory.DataProcessing;
using CSharp_Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Inventory
{
    public partial class TradeHIstoryItemViewForm : Form
    {
        string selectedTradeType;
        List<StockItemModel> stockItemList;
        List<SaleItemModel> saleItemList;
        public TradeHIstoryItemViewForm(string _selectedTradeType, List<StockItemModel> _stockItemList, List<SaleItemModel> _saleItemList)
        {
            InitializeComponent();

            selectedTradeType = _selectedTradeType;
            stockItemList = _stockItemList;
            saleItemList = _saleItemList;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TradeHIstoryItemViewForm_Load(object sender, EventArgs e)
        {
            if(selectedTradeType == "stock")
            {
                ItemsDataGridView.DataSource = stockItemList.Select(
                    source => new StockItemViewModel(source)
                    {
                        Name = source.Item.ItemName,
                        Category = source.Item.Category.CategoryName,
                        UnitPrice = source.Item.UnitPrice,
                        StockQuantity = source.ItemStockQuantity,
                        TotalPrice = source.ItemTotalPrice
                    }
                ).ToList();
                ItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";
                ItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "0.00";
            }
            else if (selectedTradeType == "sale")
            {
                ItemsDataGridView.DataSource = saleItemList.Select(
                    source => new SaleItemViewModel(source)
                    {
                        Name = source.Item.ItemName,
                        Category = source.Item.Category.CategoryName,
                        UnitPrice = source.Item.UnitPrice * 1.25m,  // apply 25% profit
                        SaleQuantity = source.ItemSaleQuantity,
                        TotalPrice = source.ItemTotalPrice * 1.25m
                    }
                ).ToList();
                ItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";
                ItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "0.00";
            }
        }
    }
}
