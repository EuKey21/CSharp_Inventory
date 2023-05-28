﻿using System;
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
        public StockManagementForm()
        {
            InitializeComponent();
        }

        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            DateTimePicker.CustomFormat = "MMMM dd yyyy";
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextbox.Clear();
            QuantityTextbox.Clear();
            DescriptionRichTextBox.Clear();
        }
    }
}