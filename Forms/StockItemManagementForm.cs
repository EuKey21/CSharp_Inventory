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
        private StockModel stock;
        private List<ItemModel> filteredItemList;
        private List<ItemModel> addedItemList;
        private List<StockItemModel> stockItemList;
        
        private ItemModel selectedItem;
        private StockItemModel selectedStockItem;
        
        public StockItemManagementForm(StockModel _stock, List<ItemModel> _filteredItemList, List<ItemModel> _addedItemList, List<StockItemModel> _stockItemList)
        {
            InitializeComponent();

            stock = _stock;
            filteredItemList = _filteredItemList;
            addedItemList = _addedItemList;
            stockItemList = _stockItemList;
        }

        
        public List<ItemModel> GetFilteredItems() => filteredItemList;
        public List<ItemModel> GetAddedItems() => addedItemList;
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
            ItemsDataGridView.DataSource = filteredItemList.Select(
                source => new ItemViewModel(source){ 
                    Name = source.ItemName, 
                    Category = source.Category.CategoryName, 
                    UnitPrice = source.UnitPrice 
                }
            ).ToList();
            ItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";

            // select the first row automatically after loading
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
                addedItemList.Add(selectedItem);
                filteredItemList.Remove(selectedItem);

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
                addedItemList.Remove(selectedItem);
                filteredItemList.Add(selectedItem);
                stockItemList.Remove(selectedStockItem);

                UpdateDataGridView();
            }
        }

        private void StockItemsListLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
