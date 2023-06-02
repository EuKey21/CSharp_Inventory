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
    public partial class SaleManagmentForm : Form
    {
        private List<ItemModel> items = Config.Connection.GetAllItem();
        private List<ItemModel> availableItemList;
        private List<ItemModel> addedItemList;
        private List<SaleItemModel> saleItemList;
        private SaleModel sale = new SaleModel();

        private readonly List<CustomerModel> customerList = Config.Connection.GetAllCustomer();
        private CustomerModel prevCustomer;

        public SaleManagmentForm()
        {
            InitializeComponent();
        }

        private void InitCustomer()
        {
            if (customerList[0] == null)
            {
                sale.Customer = new CustomerModel();
                sale.Customer.Id = -1;
                sale.Customer.FirstName = "<please_insert_customer>";
                sale.Customer.LastName = "";
                sale.Customer.Phone = -1;
            }
            else
            {
                sale.Customer = customerList[0];
            }
        }

        private void InitItemLists()
        {
            availableItemList = items.Where(source => source.Quantity > 0).ToList();
            addedItemList = new List<ItemModel>();
            saleItemList = new List<SaleItemModel>();    
        }

        private void ClearInput()
        {
            InitItemLists();

            CustomerComboBox.Text = "<select>";
            SalePriceTextbox.Clear();
            DescriptionRichTextBox.Clear();
        }

        private void RefreshDataGridView()
        {
            if (saleItemList != null)
            {
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

                SaleItemsDataGridView.Columns["UnitPrice"].DefaultCellStyle.Format = "$0.00";
                SaleItemsDataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "$0.00";
            }
        }

        private bool ValidForm()
        {
            if (CustomerComboBox.Text == "<select>" || CustomerComboBox.Text == "<please_insert_customer>")
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            if (SalePriceTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            if (saleItemList.Count == 0)
            {
                MessageBox.Show("Please fill all items");
                return false;
            }

            return true;
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaleManagmentForm_Load(object sender, EventArgs e)
        {
            // 25% of profit apply to all items
            foreach (ItemModel item in items)
            {
                item.UnitPrice *= 1.25m;
            }

            DateTimePicker.CustomFormat = "MMMM dd yyyy";

            InitCustomer();
            InitItemLists();

            CustomerComboBox.DataSource = customerList;
            CustomerComboBox.DisplayMember = Table.CustomerColumn.FullName;
            CustomerComboBox.Text = "<select>";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void AddSaleItemButton_Click(object sender, EventArgs e)
        {
            if(CustomerComboBox.Text == "<select>" || CustomerComboBox.Text == "<please_insert_customer>")
            {
                MessageBox.Show("Please select customer");
                return;
            }

            sale.Customer = (CustomerModel)CustomerComboBox.SelectedItem;

            // Refresh the list if the user change the supplier and click addItem
            if (sale.Customer != prevCustomer)
            {
                InitItemLists();
                prevCustomer = sale.Customer;
            }

            SaleItemManagementForm childForm = new SaleItemManagementForm(sale, availableItemList, addedItemList, saleItemList);
            childForm.ShowDialog();
            availableItemList = childForm.GetAvailableItemList();
            addedItemList = childForm.GetAddedItemList();
            saleItemList = childForm.GetSaleItemList();
            RefreshDataGridView();
            sale.SalePrice = 0;
            foreach (SaleItemModel saleItem in saleItemList)
            {
                sale.SalePrice += saleItem.ItemTotalPrice;
            }
            SalePriceTextbox.Text = String.Format("{0:0.00}", sale.SalePrice);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(ValidForm())
            {
                // sale.Id is auto incremented in Database
                // sale.Customer is assigned in the AddSaleItem section
                sale.SalePrice = decimal.Parse(SalePriceTextbox.Text);
                sale.Date = DateTimePicker.Value;
                sale.Description = DescriptionRichTextBox.Text;

                // Add to the SQL
                sale.Id = Config.Connection.AddSale(sale);
                Config.Connection.AddTradeHistory_Sale(sale);

                foreach (SaleItemModel saleItem in saleItemList)
                {
                    saleItem.Sale = sale;
                    Config.Connection.AddSaleItem(saleItem);
                    Config.Connection.UpdateItem_Quantity(saleItem.Item, saleItem.Item.Quantity - saleItem.ItemSaleQuantity);
                }
                MessageBox.Show("Sale Successfully Added");
                ClearInput();
            }
        }
    }
}
