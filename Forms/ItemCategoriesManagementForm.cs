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
    public partial class ItemCategoriesManagementForm : Form
    {
        private void ClearInput()
        {
            IdTextbox.Clear();
            CategoryTextbox.Clear();
        }

        public ItemCategoriesManagementForm()
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private bool ValidateForm()
        {
            if (CategoryTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
            else if (Config.Connection.IsDataUnique(Table.ItemCategory, "CategoryName", CategoryTextbox.Text) == false)
            {
                MessageBox.Show("Category already exists");
                return false;
            }

            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm() == true)
            {
                CategoryModel category = new CategoryModel();
                category.CategoryName = CategoryTextbox.Text;

                Config.Connection.AddCategory(category);
                MessageBox.Show("Category Successfully Added");
                CategoriesDataGridView.DataSource = Config.Connection.PopulateTable(Table.ItemCategory);
                ClearInput();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm() == true && IdTextbox.Text.Length != 0)
            {
                CategoryModel category = new CategoryModel();
                category.Id = int.Parse(IdTextbox.Text);
                category.CategoryName = CategoryTextbox.Text;

                Config.Connection.EditCategory(category);
                MessageBox.Show("Category Successfully Editted");
                CategoriesDataGridView.DataSource = Config.Connection.PopulateTable(Table.ItemCategory);
                ClearInput();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(IdTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please select record to be deleted");
            }
            else
            {
                Config.Connection.DeleteRecord(Table.ItemCategory, Table.ItemCategoryColumn.Id, IdTextbox.Text);
                MessageBox.Show("Category Successfully Deleted");
                CategoriesDataGridView.DataSource = Config.Connection.PopulateTable(Table.ItemCategory);
                ClearInput();
            }
        }

        private void ItemCategoriesManagementForm_Load(object sender, EventArgs e)
        {
            CategoriesDataGridView.DataSource = Config.Connection.PopulateTable(Table.ItemCategory);
        }

        private void CategoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoriesDataGridView.Rows[e.RowIndex];

                IdTextbox.Text = row.Cells[0].Value.ToString();
                CategoryTextbox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void CategoriesDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SharedMethods.PrintRowNumToGridView(sender, e);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
