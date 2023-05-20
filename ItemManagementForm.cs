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
    public partial class ItemManagementForm : Form
    {
        const string table = "ItemTable";
        const string primaryKeyLabel = "Id";

        public ItemManagementForm()
        {
            InitializeComponent();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemManagementForm_Load(object sender, EventArgs e)
        {
            ItemsDataGridView.DataSource = Config.Connection.PopulateTable(table);
            ItemsDataGridView.Columns["Price"].DefaultCellStyle.Format = "0.00";
            CategoryComboBox.DataSource = Config.Connection.GetAllCategory();
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextbox.Clear();
            ItemNameTextbox.Clear();
            QuantityTextbox.Clear();
            PriceTextbox.Clear();
            DescriptionRichTextBox.Clear();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (IdTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please select record to be deleted");
            }
            else
            {
                Config.Connection.DeleteRecord(table, primaryKeyLabel, IdTextbox.Text);
                MessageBox.Show("Customer Successfully Deleted");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(table);
            }
        }

        private bool ValidateForm()
        {
            if(ItemNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (QuantityTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (PriceTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (CategoryComboBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            return true;
        }

        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ItemsDataGridView.Rows[e.RowIndex];

                IdTextbox.Text = row.Cells[0].Value.ToString();
                ItemNameTextbox.Text = row.Cells[1].Value.ToString();
                QuantityTextbox.Text = row.Cells[2].Value.ToString();
                PriceTextbox.Text = String.Format("{0:0.00}", row.Cells[3].Value);
                CategoryComboBox.Text = row.Cells[4].Value.ToString();
                DescriptionRichTextBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void ItemsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SharedMethods.PrintRowNumToGridView(sender, e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                ItemModel item = new ItemModel();
                item.ItemName = ItemNameTextbox.Text;
                item.Quantity = int.Parse(QuantityTextbox.Text);
                item.Price = double.Parse(PriceTextbox.Text);
                item.Category = CategoryComboBox.Text;
                item.Description = DescriptionRichTextBox.Text;

                Config.Connection.AddItem(item);
                MessageBox.Show("Item Successfully Added");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(table);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                ItemModel item = new ItemModel();
                item.Id = int.Parse(IdTextbox.Text);
                item.ItemName = ItemNameTextbox.Text;
                item.Quantity = int.Parse(QuantityTextbox.Text);
                item.Price = double.Parse(PriceTextbox.Text);
                item.Category = CategoryComboBox.Text;
                item.Description = DescriptionRichTextBox.Text;

                Config.Connection.EditItem(item);
                MessageBox.Show("Item Successfully Editted");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(table);
            }
        }
    }
}
