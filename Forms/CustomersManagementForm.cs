﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Inventory.DataProcessing;
using CSharp_Inventory.Models;

namespace CSharp_Inventory
{
    public partial class CustomersManagementForm : Form
    {
        private void ClearInput()
        {
            IdTextbox.Clear();
            FirstNameTextbox.Clear();
            LastNameTextbox.Clear();
            PhoneTextbox.Clear();
        }

        public CustomersManagementForm()
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
            if (FirstNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill all boxes");
                return false;
            }

            if (LastNameTextbox.Text.Length == 0)
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm() == true)
            {
                CustomerModel customer = new CustomerModel();
                customer.FirstName = FirstNameTextbox.Text;
                customer.LastName = LastNameTextbox.Text;
                customer.Phone = int.Parse(PhoneTextbox.Text);

                Config.Connection.AddCustomer(customer);
                MessageBox.Show("Customers Successfully Added");
                CustomersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Customer);
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
                Config.Connection.DeleteRecord(Table.Customer, Table.CustomerColumn.Id, IdTextbox.Text);
                MessageBox.Show("Customer Successfully Deleted");
                CustomersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Customer);
                ClearInput();
            }
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            CustomersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Customer);
        }

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomersDataGridView.Rows[e.RowIndex];

                IdTextbox.Text = row.Cells[0].Value.ToString();
                FirstNameTextbox.Text = row.Cells[1].Value.ToString();
                LastNameTextbox.Text = row.Cells[2].Value.ToString();
                PhoneTextbox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void CustomersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SharedMethods.PrintRowNumToGridView(sender, e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true && IdTextbox.Text.Length != 0)
            {
                CustomerModel customer = new CustomerModel();
                customer.Id = int.Parse(IdTextbox.Text);
                customer.FirstName = FirstNameTextbox.Text;
                customer.LastName = LastNameTextbox.Text;
                customer.Phone = int.Parse(PhoneTextbox.Text);

                Config.Connection.EditCustomer(customer);
                MessageBox.Show("Customer Successfully Editted");
                CustomersDataGridView.DataSource = Config.Connection.PopulateTable(Table.Customer);
                ClearInput();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
