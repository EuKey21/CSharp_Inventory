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
        private readonly List<CategoryModel> categories = Config.Connection.GetAllCategory();
        private readonly List<SupplierModel> suppliers = Config.Connection.GetAllSupplier();

        public ItemManagementForm()
        {
            InitializeComponent();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetupComboBoxes()
        {
            CategoryNameComboBox.DataSource = categories;
            CategoryNameComboBox.DisplayMember = Table.ItemCategoryColumn.CategoryName;
            CategoryNameComboBox.Text = "<select>";

            SupplierNameComboBox.DataSource = suppliers;
            SupplierNameComboBox.DisplayMember = Table.SupplierColumn.SupplierName;
            SupplierNameComboBox.Text = "<select>";
        }

        private void ClearInput()
        {
            IdTextbox.Clear();
            CategoryNameComboBox.Text = "<select>";
            SupplierNameComboBox.Text = "<select>";
            ItemNameTextbox.Clear();
            QuantityTextbox.Clear();
            UnitPriceTextbox.Clear();
            DescriptionRichTextBox.Clear();
        }

        private void ItemManagementForm_Load(object sender, EventArgs e)
        {
            ItemsDataGridView.DataSource = Config.Connection.PopulateTable(Table.Item);
            ItemsDataGridView.Columns[Table.ItemColumn.UnitPrice].DefaultCellStyle.Format = "0.00";

            SetupComboBoxes();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (IdTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please select record to be deleted");
            }
            else if(int.Parse(QuantityTextbox.Text) != 0)
            {
                MessageBox.Show("Item cannot be deleted because quantity is not 0");
            }
            else
            {
                Config.Connection.DeleteRecord(Table.Item, Table.ItemColumn.Id, IdTextbox.Text);
                MessageBox.Show("Item Successfully Deleted");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(Table.Item);
                ClearInput();
            }
        }

        private bool ValidateForm()
        {
            if(ItemNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if(CategoryNameComboBox.Text == "<select>")
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (SupplierNameComboBox.Text == "<select>")
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (UnitPriceTextbox.Text.Length == 0)
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
                CategoryNameComboBox.Text = row.Cells[2].Value.ToString();
                SupplierNameComboBox.Text = row.Cells[3].Value.ToString();
                QuantityTextbox.Text = row.Cells[4].Value.ToString();
                UnitPriceTextbox.Text = String.Format("{0:0.00}", row.Cells[5].Value);
                DescriptionRichTextBox.Text = row.Cells[6].Value.ToString();
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
                item.Category = (CategoryModel)CategoryNameComboBox.SelectedItem;
                item.Supplier = (SupplierModel)SupplierNameComboBox.SelectedItem;
                item.Quantity = 0;
                item.UnitPrice = double.Parse(UnitPriceTextbox.Text);
                item.Description = DescriptionRichTextBox.Text;

                Config.Connection.AddItem(item);
                MessageBox.Show("Item Successfully Added");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(Table.Item);
                ClearInput();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true && IdTextbox.Text.Length != 0)
            {
                ItemModel item = new ItemModel();
                item.Id = int.Parse(IdTextbox.Text);
                item.ItemName = ItemNameTextbox.Text;
                item.Category = (CategoryModel)CategoryNameComboBox.SelectedItem;
                item.Supplier = (SupplierModel)SupplierNameComboBox.SelectedItem;
                item.Quantity = int.Parse(QuantityTextbox.Text);
                item.UnitPrice = double.Parse(UnitPriceTextbox.Text);
                item.Description = DescriptionRichTextBox.Text;

                Config.Connection.EditItem(item);
                MessageBox.Show("Item Successfully Editted");
                ItemsDataGridView.DataSource = Config.Connection.PopulateTable(Table.Item);
                ClearInput();
            }
        }
    }
}
