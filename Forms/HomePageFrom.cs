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
    public partial class HomePageFrom : Form
    {
        PersonModel user;
        public HomePageFrom(PersonModel _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Terminate the application? ", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ManageUserButton_Click(object sender, EventArgs e)
        {
            UsersManagementForm childForm = new UsersManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageSupplierButton_Click(object sender, EventArgs e)
        {
            SuppliersManagementForm childForm = new SuppliersManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageCustomerButton_Click(object sender, EventArgs e)
        {
            CustomersManagementForm childForm = new CustomersManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageItemCategoryButton_Click(object sender, EventArgs e)
        {
            ItemCategoriesManagementForm childForm = new ItemCategoriesManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageItemButton_Click(object sender, EventArgs e)
        {
            ItemManagementForm childForm = new ItemManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageStockButton_Click(object sender, EventArgs e)
        {
            StockManagementForm childForm = new StockManagementForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ManageSaleButton_Click(object sender, EventArgs e)
        {
            SaleManagmentForm childForm = new SaleManagmentForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }

        private void ViewTradeHistoryButton_Click(object sender, EventArgs e)
        {
            TradeHistoryViewForm childForm = new TradeHistoryViewForm();
            Hide();
            childForm.ShowDialog();
            Show();
        }
    }
}
