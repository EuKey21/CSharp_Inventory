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
    public partial class SaleItemManagementForm : Form
    {
        private SaleModel sale;
        private List<ItemModel> availableItemList;
        private List<ItemModel> addedItemList;
        private List<SaleItemModel> saleItemList;

        private ItemModel selectedItem;
        private SaleItemModel selectedSaleItem;

        public SaleItemManagementForm(SaleModel _sale, List<ItemModel> _availableItemList, List<ItemModel> _addedItemList, List<SaleItemModel> _saleItemList)
        {
            InitializeComponent();

            sale = _sale;
            availableItemList = _availableItemList;
            addedItemList = _addedItemList;
            saleItemList = _saleItemList;
        }

        public List<ItemModel> GetAvailableItemList() => availableItemList;
        public List<ItemModel> GetAddedItemList() => addedItemList;
        public List<SaleItemModel> GetSaleItemList() => saleItemList;

        private SaleItemModel TranslateItemToSaleItem(ItemModel item, int quantity)
        {
            SaleItemModel saleItem = new SaleItemModel();

            saleItem.Sale = sale;
            saleItem.Item = item;
            saleItem.ItemSaleQuantity = quantity;

            return saleItem;
        }

        private void UpdateDataGridView()
        {
            ItemsDataGridView.DataSource = null;    // force data to refresh
            ItemsDataGridView.DataSource = availableItemList.Select(
                source => new ItemViewModel(source)
                {
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

            SaleItemsDataGridView.DataSource = null;
            SaleItemsDataGridView.DataSource = saleItemList.Select(
                source => new SaleItemViewModel(source)
                {
                    Name = source.Item.ItemName,
                    Category = source.Item.Category.CategoryName,
                    UnitPrice = source.Item.UnitPrice,
                    SaleQuantity = source.ItemSaleQuantity,
                    TotalPrice = source.ItemTotalPrice
                }
            ).ToList();
            SaleItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";
            SaleItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "0.00";

            if (SaleItemsDataGridView.Rows.Count > 0)
            {
                SaleItemsDataGridView.FirstDisplayedScrollingRowIndex = 0;
                selectedSaleItem = ((SaleItemViewModel)SaleItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaleItemManagementForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = ((ItemViewModel)ItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
        }

        private void SaleItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSaleItem = ((SaleItemViewModel)SaleItemsDataGridView.CurrentRow.DataBoundItem).GetModel();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                SaleItemQuantityForm childForm = new SaleItemQuantityForm();
                childForm.ShowDialog();
                int quantity = childForm.GetQuantity();

                if(quantity > selectedItem.Quantity)
                {
                    MessageBox.Show("Do not have enough items");
                    return;
                }

                addedItemList.Add(selectedItem);
                availableItemList.Remove(selectedItem);
                saleItemList.Add(TranslateItemToSaleItem(selectedItem, quantity));

                UpdateDataGridView();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (selectedSaleItem != null)
            {
                selectedItem = selectedSaleItem.Item;
                addedItemList.Remove(selectedItem);
                availableItemList.Add(selectedItem);
                saleItemList.Remove(selectedSaleItem);

                UpdateDataGridView();
            }

        }
    }
}
