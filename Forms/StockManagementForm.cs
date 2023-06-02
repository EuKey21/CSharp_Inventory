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
    public partial class StockManagementForm : Form
    {
        private readonly List<ItemModel> items = Config.Connection.GetAllItem();
        private List<ItemModel> filteredItemList;
        private List<ItemModel> addedItemList;
        private List<StockItemModel> stockItemList;
        private StockModel stock = new StockModel();

        private readonly List<SupplierModel> suppliers = Config.Connection.GetAllSupplier();
        private SupplierModel prevSupplier;

        public StockManagementForm()
        {
            InitializeComponent();
        }
    
        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            DateTimePicker.CustomFormat = "MMMM dd yyyy";

            InitSupplier();
            InitItemLists();

            SupplierComboBox.DataSource = suppliers;
            SupplierComboBox.DisplayMember = Table.SupplierColumn.SupplierName;
            SupplierComboBox.Text = "<select>";

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if (stockItemList != null)
            {
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

                StockItemsDataGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "$0.00";
                StockItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "$0.00";
            }
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            InitSupplier();
            InitItemLists();

            SupplierComboBox.Text = "<select>";
            StockPriceTextbox.Clear();
            DescriptionRichTextBox.Clear();
        }

        private void InitItemLists()
        {
            filteredItemList = items.Where(source => source.Supplier.SupplierName == stock.Supplier.SupplierName).ToList();
            addedItemList = new List<ItemModel>();
            stockItemList = new List<StockItemModel>();
        }

        private void InitSupplier()
        {
            // init the Supplier to avoid null and make sure (stock.Supplier == prevSupplier) works
            // In case the supplier table is empty
            if (suppliers[0] == null)
            {
                stock.Supplier = new SupplierModel();
                stock.Supplier.Id = -1;
                stock.Supplier.SupplierName = "<please_insert_supplier>";
                stock.Supplier.Phone = -1;
            }
            else
            {
                stock.Supplier = suppliers[0];
            }
        }

        private void AddStockItemButton_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.Text == "<select>" || SupplierComboBox.Text == "<please_insert_supplier>")
            {
                MessageBox.Show("Please select supplier");
                return;
            }

            stock.Supplier = (SupplierModel)SupplierComboBox.SelectedItem;

            // Refresh the list if the user change the supplier and click addItem
            if (stock.Supplier != prevSupplier)
            {
                InitItemLists();
                prevSupplier = stock.Supplier;
            }

            SelectedSupplierLabel.Text = stock.Supplier.SupplierName;

            StockItemManagementForm childForm = new StockItemManagementForm(stock, filteredItemList, addedItemList, stockItemList);
            childForm.ShowDialog();
            filteredItemList = childForm.GetFilteredItems();
            addedItemList = childForm.GetAddedItems();
            stockItemList = childForm.GetStockItemList();
            RefreshDataGridView();
            stock.StockPrice = 0;
            foreach(StockItemModel stockItem in stockItemList)
            {
                stock.StockPrice += stockItem.ItemTotalPrice;
            }
            StockPriceTextbox.Text = String.Format("{0:0.00}", stock.StockPrice);
        }

        private bool ValidForm()
        {
            if(SupplierComboBox.Text == "<select>" || SupplierComboBox.Text == "<please_insert_supplier>")
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            if(StockPriceTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            if(stockItemList.Count == 0)
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            return true;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(ValidForm())
            {
                // stock.Id is auto incremented in Database
                // stock.Supplier is assigned in the AddStockItem section
                stock.StockPrice = decimal.Parse(StockPriceTextbox.Text);
                stock.Date = DateTimePicker.Value;
                stock.Description = DescriptionRichTextBox.Text;

                // Add to the SQL
                stock.Id = Config.Connection.AddStock(stock);
                Config.Connection.AddTradeHistory_Stock(stock);
                
                foreach (StockItemModel stockItem in stockItemList)
                {
                    stockItem.Stock = stock;
                    Config.Connection.AddStockItem(stockItem);
                    Config.Connection.UpdateItem_Quantity(stockItem.Item, stockItem.Item.Quantity + stockItem.ItemStockQuantity);
                }
                MessageBox.Show("Stock Successfully Added");
                ClearInput();
            }
        }
    }
}
