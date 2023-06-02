using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory.DataProcessing
{
    static class Table
    {

        public static string Customer { get { return new string("CustomerTable"); } }

        public static class CustomerColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string FirstName { get { return new string("FirstName"); } }

            public static string LastName { get { return new string("LastName"); } }

            public static string Phone { get { return new string("Phone"); } }

            public static string FullName { get { return new string("FullName"); } }
        }

        public static string ItemCategory { get { return new string("ItemCategoryTable"); } }

        public static class ItemCategoryColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string CategoryName { get { return new string("CategoryName"); } }
        }

        public static string Item { get { return new string("ItemTable"); } }

        public static class ItemColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string ItemName { get { return new string("ItemName"); } }

            public static string CategoryId { get { return new string("CategoryId"); } }

            public static string SupplierId { get { return new string("SupplierId"); } }

            public static string Quantity { get { return new string("Quantity"); } }

            public static string UnitPrice { get { return new string("UnitPrice"); } }

            public static string Description { get { return new string("Description"); } }
        }

        public static string Stock { get { return new string("StockTable"); } }

        public static class StockColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string SupplierId { get { return new string("SupplierId"); } }

            public static string StockItemList { get { return new string("StockItemList"); } }

            public static string StockPrice { get { return new string("StockPrice"); } }

            public static string Date { get { return new string("Date"); } }

            public static string Description { get { return new string("Description"); } }
            
        }

        public static string StockItem { get { return new string("StockItemTable"); } }

        public static class StockItemColumn
        {
            public static string StockId { get { return new string("StockId"); } }

            public static string ItemId { get { return new string("ItemId"); } }

            public static string ItemStockQuantity { get { return new string("ItemStockQuantity"); } }

            public static string ItemTotalPrice { get { return new string("ItemTotalPrice"); } }
        }

        public static string Sale { get { return new string("SaleTable"); } }

        public static class SaleColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string CustomerId { get { return new string("CustomerId"); } }

            public static string SaleItemList { get { return new string("SaleItemList"); } }

            public static string SalePrice { get { return new string("SalePrice"); } }

            public static string Date { get { return new string("Date"); } }

            public static string Description { get { return new string("Description"); } }
        }

        public static string SaleItem { get { return new string("SaleItemTable"); } }

        public static class SaleItemColumn
        {
            public static string SaleId { get { return new string("SaleId"); } }

            public static string ItemId { get { return new string("ItemId"); } }

            public static string ItemSaleQuantity { get { return new string("ItemSaleQuantity"); } }

            public static string ItemTotalPrice { get { return new string("ItemTotalPrice"); } }
        }

        public static string Supplier { get { return new string("SupplierTable"); } }

        public static class SupplierColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string SupplierName { get { return new string("SupplierName"); } }

            public static string Phone { get { return new string("Phone"); } }
        }

        public static string TradeHistory { get { return new string("TradeHistoryTable"); } }

        public static class TradeHistoryColumn
        {
            public static string Id { get { return new string("Id"); } }
            public static string StockId { get { return new string("StockId"); } }
            public static string SaleId { get { return new string("SaleId"); } }
            public static string Total { get { return new string("Total"); } }
            public static string Date { get { return new string("Date"); } }
        }

        public static string User { get { return new string("UserTable"); } }

        public static class UserColumn
        {
            public static string UserName { get { return new string("UserName"); } }

            public static string Password { get { return new string("Password"); } }

            public static string FirstName { get { return new string("FirstName"); } }

            public static string LastName { get { return new string("LastName"); } }

            public static string Gender { get { return new string("Gender"); } }

            public static string Age { get { return new string("Age"); } }

            public static string Email { get { return new string("Email"); } }
        }


    }
}
