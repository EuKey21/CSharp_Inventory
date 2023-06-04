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
    public partial class TradeHistoryViewForm : Form
    {
        TradeHistoryModel selectedTradeHistory;
        string selectedTradeType;
        int selectedItemListId;
        List<StockItemModel> stockItemList;
        List<SaleItemModel> saleItemList;

        public TradeHistoryViewForm()
        {
            InitializeComponent();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Terminate the application? ", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void TradeHistoryViewForm_Load(object sender, EventArgs e)
        {
            List<TradeHistoryModel> tradeHistories = Config.Connection.GetAllTradeHistory();
            TradeHistoryDataGridView.DataSource = tradeHistories.Select(
                source => new TradeHistoryViewModel(source)
                {
                    Id = source.Id,
                    SupplierName = (source.Stock != null) ? source.Stock.Supplier.SupplierName : "NULL",
                    CustomerName = (source.Sale != null) ? source.Sale.Customer.FullName : "NULL",
                    Total = source.Total,
                    Date = source.Date
                }
            ).ToList();

            decimal netIncome = 0m;
            foreach (TradeHistoryModel tradeHistory in tradeHistories)
            {
                netIncome += tradeHistory.Total;
            }
            NetIncomeTextbox.Text = String.Format("{0:0.00}", netIncome);

            // select the first row by default
            if(TradeHistoryDataGridView.Rows.Count > 0)
            {
                TradeHistoryDataGridView.FirstDisplayedScrollingRowIndex = 0;
                SelectedRow();
            }
        }

        private void TradeHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow();
        }

        private void SelectedRow()
        {
            selectedTradeHistory = ((TradeHistoryViewModel)TradeHistoryDataGridView.CurrentRow.DataBoundItem).GetModel();

            if (selectedTradeHistory.Stock != null)
            {
                selectedTradeType = "stock";
                selectedItemListId = selectedTradeHistory.Stock.Id;
                stockItemList = Config.Connection.GetStockItemList(selectedItemListId);
            }
            else if (selectedTradeHistory.Sale != null)
            {
                selectedTradeType = "sale";
                selectedItemListId = selectedTradeHistory.Sale.Id;
                saleItemList = Config.Connection.GetSaleItemList(selectedItemListId);
            }


        }

        private void ViewItemButton_Click(object sender, EventArgs e)
        {
            TradeHIstoryItemViewForm childForm = new TradeHIstoryItemViewForm(selectedTradeType, stockItemList, saleItemList);
            childForm.ShowDialog();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
