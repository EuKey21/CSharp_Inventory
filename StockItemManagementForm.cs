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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Inventory
{
    public partial class StockItemManagementForm : Form
    {
        private readonly List<ItemModel> items = Config.Connection.GetAllItem();
        private List<ItemModel> filteredItems;
        private List<ItemModel> addedItems = new List<ItemModel>();
        private List<StockItemModel> stockItemList = new List<StockItemModel>();
        private ItemModel selectedItem;
        private StockItemModel selectedStockItem;
        private StockModel stock;
        public StockItemManagementForm(StockModel stockModel)
        {
            InitializeComponent();

            stock = stockModel;

            filteredItems = items.Where(source => source.Supplier.SupplierName == stock.Supplier.SupplierName).ToList();
        }

        public List<StockItemModel> GetStockItemList() => stockItemList;

        private StockItemModel TranslateItemToStockItem(ItemModel item, int quantity)
        {
            StockItemModel stockItem = new StockItemModel();

            stockItem.Stock = stock;
            stockItem.Item = item;
            stockItem.ItemStockQuantity = quantity;

            return stockItem;
        }

        private void UpdateDataGridView()
        {
            ItemsDataGridView.DataSource = null;    // force data to refresh
            ItemsDataGridView.DataSource = filteredItems.Select(
                source => new ItemViewModel(source){ 
                    Name = source.ItemName, 
                    Category = source.Category.CategoryName, 
                    UnitPrice = source.UnitPrice 
                }
            ).ToList();
            ItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";

            // select the first road automatically after loading
            if (ItemsDataGridView.Rows.Count > 0)
            {
                ItemsDataGridView.FirstDisplayedScrollingRowIndex = 0;
                selectedItem = ((ItemViewModel)ItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
            }

            StockItemsDataGridView.DataSource = null;
            StockItemsDataGridView.DataSource = stockItemList.Select(
                source => new StockItemViewModel(source)
                {
                    Name = source.Item.ItemName,
                    Category = source.Item.Category.CategoryName,
                    UnitPrice = source.Item.UnitPrice,
                    StockQuantity = source.ItemStockQuantity,
                    TotalPrice = source.ItemTotalPrice
                }
            ).ToList();
            StockItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";
            StockItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "0.00";

            if(StockItemsDataGridView.Rows.Count > 0)
            {
                StockItemsDataGridView.FirstDisplayedScrollingRowIndex = 0;
                selectedStockItem = ((StockItemViewModel)StockItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StockItemManagementForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = ((ItemViewModel)ItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
        }

        private void StockItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStockItem = ((StockItemViewModel)StockItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                addedItems.Add(selectedItem);
                filteredItems.Remove(selectedItem);

                StockItemQuantityForm childForm = new StockItemQuantityForm();
                childForm.ShowDialog();
                int quantity = childForm.GetQuantity();

                stockItemList.Add(TranslateItemToStockItem(selectedItem, quantity));

                UpdateDataGridView();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (selectedStockItem != null)
            {
                selectedItem = selectedStockItem.Item;
                addedItems.Remove(selectedItem);
                filteredItems.Add(selectedItem);
                stockItemList.Remove(selectedStockItem);

                UpdateDataGridView();
            }
        }

        
    }
}
