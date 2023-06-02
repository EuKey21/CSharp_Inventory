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
    public partial class StockItemQuantityForm : Form
    {
        int quantity = 0;

        public StockItemQuantityForm()
        {
            InitializeComponent();

        }

        public int GetQuantity() => quantity; 

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(QuantityTextbox.Text);

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
