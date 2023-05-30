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
        List<StockItemModel> StockItems = new List<StockItemModel>();

        public StockManagementForm()
        {
            InitializeComponent();
        }
    
        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            DateTimePicker.CustomFormat = "MMMM dd yyyy";

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if (StockItems != null)
            {
                StockItemsDataGridView.DataSource = null;
                StockItemsDataGridView.DataSource = StockItems;
            }
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextbox.Clear();
            
            DescriptionRichTextBox.Clear();
        }

        private void AddStockItemButton_Click(object sender, EventArgs e)
        {
            SupplierModel supplier = new SupplierModel();
            supplier.Id = 55;
            supplier.SupplierName = "Red";
            supplier.Phone = 93939;

            StockModel model = new StockModel();
            model.Id = 2;
            model.Supplier = supplier;
            


            StockItemManagementForm childForm = new StockItemManagementForm(model);
            childForm.ShowDialog();
            StockItems = childForm.GetStockItemList();
            RefreshDataGridView();
        }
    }
}
