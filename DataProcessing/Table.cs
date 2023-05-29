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

        public static string Stock { get { return new string("StockTable"); } } // TODO

        public static string Supplier { get { return new string("SupplierTable"); } }

        public static class SupplierColumn
        {
            public static string Id { get { return new string("Id"); } }

            public static string SupplierName { get { return new string("SupplierName"); } }

            public static string Phone { get { return new string("Phone"); } }
        }

        public static string User { get { return new string("UserTbale"); } }

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
