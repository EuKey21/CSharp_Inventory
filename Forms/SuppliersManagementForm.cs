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
    public partial class SuppliersManagementForm : Form
    {
        public SuppliersManagementForm()
        {
            InitializeComponent();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInput()
        {
            IdTextbox.Clear();
            SupplierNameTextbox.Clear();
            PhoneTextbox.Clear();
        }

        private bool ValidateForm()
        {
            if (SupplierNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (PhoneTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }
            else if (int.TryParse(PhoneTextbox.Text, out _) == false)
            {
                MessageBox.Show("Phone can only be numeric");
                return false;
            }

            return true;
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
            else
            {
                Config.Connection.DeleteRecord(Table.Supplier, Table.SupplierColumn.Id, IdTextbox.Text);
                MessageBox.Show("Customer Successfully Deleted");
                SuppliersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Supplier);
                ClearInput();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                SupplierModel supplier = new SupplierModel();
                supplier.SupplierName = SupplierNameTextbox.Text;
                supplier.Phone = int.Parse(PhoneTextbox.Text);

                Config.Connection.AddSupplier(supplier);
                MessageBox.Show("Supplier Successfully Added");
                SuppliersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Supplier);
                ClearInput();
            }
        }

        private void SuppliersManagementForm_Load(object sender, EventArgs e)
        {
            SuppliersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Supplier);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true && IdTextbox.Text.Length != 0)
            {
                SupplierModel supplier = new SupplierModel();
                supplier.Id = int.Parse(IdTextbox.Text);
                supplier.SupplierName = SupplierNameTextbox.Text;
                supplier.Phone = int.Parse(PhoneTextbox.Text);

                Config.Connection.EditSupplier(supplier);
                MessageBox.Show("Supplier Successfully Editted");
                SuppliersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Supplier);
                ClearInput();
            }
        }

        private void SuppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SuppliersDataGridView.Rows[e.RowIndex];

                IdTextbox.Text = row.Cells[0].Value.ToString();
                SupplierNameTextbox.Text = row.Cells[1].Value.ToString();
                PhoneTextbox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void SuppliersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SharedMethods.PrintRowNumToGridView(sender, e);
        }
    }
}
