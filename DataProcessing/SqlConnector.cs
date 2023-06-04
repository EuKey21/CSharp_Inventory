using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using CSharp_Inventory.Models;

namespace CSharp_Inventory.DataProcessing
{
    public class SqlConnector : IDataConnection
    {
        private readonly string connectionString = @"";

        public bool ValidateLogin(string username, string password)
        {
            bool result = false;

            string query = "SELECT COUNT(*) FROM " + Table.User;
            query += " WHERE " + Table.UserColumn.UserName + " = @Username";
            query += " AND " + Table.UserColumn.Password + " = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0) result = true;

                    // username is primary key, so there is only one possible match
                }
            }

            return result;
        }

        public void AddPerson(in PersonModel model)
        {
            string query = "INSERT INTO " + Table.User + " (";
            query += Table.UserColumn.UserName + ", ";
            query += Table.UserColumn.Password + ", ";
            query += Table.UserColumn.FirstName + ", ";
            query += Table.UserColumn.LastName + ", ";
            query += Table.UserColumn.Gender + ", ";
            query += Table.UserColumn.Age + ", ";
            query += Table.UserColumn.Email + ") ";
            query += "VALUES (@Username, @Password, @FirstName, @LastName, @Gender, @Age, @Email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", model.UserName);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditPerson(in PersonModel model)
        {
            string query = "UPDATE " + Table.User + " SET ";
            query += Table.UserColumn.Password + " = @Password, ";
            query += Table.UserColumn.FirstName + " = @FirstName, ";
            query += Table.UserColumn.LastName + " = @LastName, ";
            query += Table.UserColumn.Gender + " = @Gender, ";
            query += Table.UserColumn.Age + " = @Age, ";
            query += Table.UserColumn.Email + " = @Email ";
            query += "WHERE " + Table.UserColumn.UserName + " = @Username";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", model.UserName);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddCustomer(in CustomerModel model)
        {
            string query = "INSERT INTO " + Table.Customer + " (";
            query += Table.CustomerColumn.FirstName + ", ";
            query += Table.CustomerColumn.LastName + ", ";
            query += Table.CustomerColumn.Phone + ") ";
            query += "VALUES (@FirstName, @LastName, @Phone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true.
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditCustomer(in CustomerModel model)
        {
            string query = "UPDATE " + Table.Customer + " SET ";
            query += Table.CustomerColumn.FirstName + " = @FirstName, ";
            query += Table.CustomerColumn.LastName + " = @LastName, ";
            query += Table.CustomerColumn.Phone + " = @Phone ";
            query += "WHERE " + Table.CustomerColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddCategory(in CategoryModel model)
        {
            string query = "INSERT INTO " + Table.ItemCategory + " (";
            query += Table.ItemCategoryColumn.CategoryName + ") VALUES (@CategoryName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true
                    cmd.Parameters.AddWithValue("@CategoryName", model.CategoryName);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditCategory(in CategoryModel model)
        {
            string query = "UPDATE " + Table.ItemCategory + " SET ";
            query += Table.ItemCategoryColumn.CategoryName + " = @CategoryName ";
            query += "WHERE " + Table.ItemCategoryColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@CategoryName", model.CategoryName);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddItem(in ItemModel model)
        {
            string query = "";

            query += "DECLARE @CategoryId INT; ";
            query += "SET @CategoryId = (SELECT " + Table.ItemCategoryColumn.Id + " ";
            query += "FROM " + Table.ItemCategory + " ";
            query += "WHERE " + Table.ItemCategoryColumn.CategoryName + " = @CategoryName); ";

            query += "DECLARE @SupplierId INT; ";
            query += "SET @SupplierId = (SELECT " + Table.SupplierColumn.Id + " ";
            query += "FROM " + Table.Supplier + " ";
            query += "WHERE " + Table.SupplierColumn.SupplierName + " = @SupplierName); ";

            query += "INSERT INTO " + Table.Item + " (";
            query += Table.ItemColumn.ItemName + ", ";
            query += Table.ItemColumn.CategoryId + ", ";
            query += Table.ItemColumn.SupplierId + ", ";
            query += Table.ItemColumn.Quantity + ", ";
            query += Table.ItemColumn.UnitPrice + ", ";
            query += Table.ItemColumn.Description + ") ";
            query += "VALUES (@ItemName, @CategoryId, @SupplierId, @Quantity, @UnitPrice, @Description)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true
                    cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                    cmd.Parameters.AddWithValue("@CategoryName", model.Category.CategoryName);
                    cmd.Parameters.AddWithValue("@SupplierName", model.Supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditItem(in ItemModel model)
        {
            string query = "";

            query += "DECLARE @CategoryId INT; ";
            query += "SET @CategoryId = (SELECT " + Table.ItemCategoryColumn.Id + " ";
            query += "FROM " + Table.ItemCategory + " ";
            query += "WHERE " + Table.ItemCategoryColumn.CategoryName + " = @CategoryName); ";

            query += "DECLARE @SupplierId INT; ";
            query += "SET @SupplierId = (SELECT " + Table.SupplierColumn.Id + " ";
            query += "FROM " + Table.Supplier + " ";
            query += "WHERE " + Table.SupplierColumn.SupplierName + " = @SupplierName); ";

            query += "UPDATE " + Table.Item + " SET ";
            query += Table.ItemColumn.ItemName + " = @ItemName, ";
            query += Table.ItemColumn.CategoryId + " = @CategoryId, ";
            query += Table.ItemColumn.SupplierId + " = @SupplierId, ";
            query += Table.ItemColumn.Quantity + " = @Quantity, ";
            query += Table.ItemColumn.UnitPrice + " = @UnitPrice, ";
            query += Table.ItemColumn.Description + " = @Description ";
            query += "WHERE " + Table.ItemColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                    cmd.Parameters.AddWithValue("@CategoryName", model.Category.CategoryName);
                    cmd.Parameters.AddWithValue("@SupplierName", model.Supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateItem_Quantity(in ItemModel model, in decimal newQuantity)
        {
            string query = "UPDATE " + Table.Item + " SET ";
            query += Table.ItemColumn.Quantity + " = @Quantity ";
            query += "WHERE " + Table.ItemColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@Quantity", newQuantity);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddStockItem(in StockItemModel model)
        {
            string query = "";

            query += "DECLARE @StockId INT; ";
            query += "SET @StockId = (SELECT " + Table.StockColumn.Id + " ";
            query += "FROM " + Table.Stock + " ";
            query += "WHERE " + Table.StockColumn.Id + " = @FK_StockId); ";

            query += "DECLARE @ItemId INT; ";
            query += "SET @ItemId = (SELECT " + Table.ItemColumn.Id + " ";
            query += "FROM " + Table.Item + " ";
            query += "WHERE " + Table.ItemColumn.Id + " = @FK_ItemId); ";

            query += "INSERT INTO " + Table.StockItem + " (";
            query += Table.StockItemColumn.StockId + ", ";
            query += Table.StockItemColumn.ItemId + ", ";
            query += Table.StockItemColumn.ItemStockQuantity + ", ";
            query += Table.StockItemColumn.ItemTotalPrice + ") ";
            query += "VALUES (@StockId, @ItemId, @ItemStockQuantity, @ItemTotalPrice)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FK_StockId", model.Stock.Id);
                    cmd.Parameters.AddWithValue("@FK_ItemId", model.Item.Id);
                    cmd.Parameters.AddWithValue("@ItemStockQuantity", model.ItemStockQuantity);
                    cmd.Parameters.AddWithValue("@ItemTotalPrice", model.ItemTotalPrice);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int AddStock(in StockModel model)
        {
            string query = "";

            query += "DECLARE @SupplierId INT; ";
            query += "SET @SupplierId = (SELECT " + Table.SupplierColumn.Id + " ";
            query += "FROM " + Table.Supplier + " ";
            query += "WHERE " + Table.SupplierColumn.Id + " = @FK_SupplierId); ";

            query += "INSERT INTO " + Table.Stock + " (";
            query += Table.StockColumn.SupplierId + ", ";
            query += Table.StockColumn.StockPrice + ", ";
            query += Table.StockColumn.Date + ", ";
            query += Table.StockColumn.Description + ") ";
            query += "OUTPUT INSERTED.Id ";     // use ExeciteScalar to retrieve the id
            query += "VALUES (@SupplierId, @StockPrice, @Date, @Description)";

            int id = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FK_SupplierId", model.Supplier.Id);
                    cmd.Parameters.AddWithValue("@StockPrice", model.StockPrice);
                    cmd.Parameters.AddWithValue("@Date", model.Date);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    id = (int)cmd.ExecuteScalar();
                }
            }

            return id;
        }

        public void AddSaleItem(in SaleItemModel model)
        {
            string query = "";

            query += "DECLARE @SaleId INT; ";
            query += "SET @SaleId = (SELECT " + Table.SaleColumn.Id + " ";
            query += "FROM " + Table.Sale + " ";
            query += "WHERE " + Table.SaleColumn.Id + " = @FK_SaleId); ";

            query += "DECLARE @ItemId INT; ";
            query += "SET @ItemId = (SELECT " + Table.ItemColumn.Id + " ";
            query += "FROM " + Table.Item + " ";
            query += "WHERE " + Table.ItemColumn.Id + " = @FK_ItemId); ";

            query += "INSERT INTO " + Table.SaleItem + " (";
            query += Table.SaleItemColumn.SaleId + ", ";
            query += Table.SaleItemColumn.ItemId + ", ";
            query += Table.SaleItemColumn.ItemSaleQuantity + ", ";
            query += Table.SaleItemColumn.ItemTotalPrice + ") ";
            query += "VALUES (@SaleId, @ItemId, @ItemSaleQuantity, @ItemTotalPrice)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FK_SaleId", model.Sale.Id);
                    cmd.Parameters.AddWithValue("@FK_ItemId", model.Item.Id);
                    cmd.Parameters.AddWithValue("@ItemSaleQuantity", model.ItemSaleQuantity);
                    cmd.Parameters.AddWithValue("@ItemTotalPrice", model.ItemTotalPrice);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public int AddSale(in SaleModel model)
        {
            string query = "";

            query += "DECLARE @CustomerId INT; ";
            query += "SET @CustomerId = (SELECT " + Table.CustomerColumn.Id + " ";
            query += "FROM " + Table.Customer + " ";
            query += "WHERE " + Table.CustomerColumn.Id + " = @FK_CustomerId); ";

            query += "INSERT INTO " + Table.Sale + " (";
            query += Table.SaleColumn.CustomerId + ", ";
            query += Table.SaleColumn.SalePrice + ", ";
            query += Table.SaleColumn.Date + ", ";
            query += Table.SaleColumn.Description + ") ";
            query += "OUTPUT INSERTED.Id ";     // use ExeciteScalar to retrieve the id
            query += "VALUES (@CustomerId, @SalePrice, @Date, @Description)";

            int id = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FK_CustomerId", model.Customer.Id);
                    cmd.Parameters.AddWithValue("@SalePrice", model.SalePrice);
                    cmd.Parameters.AddWithValue("@Date", model.Date);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    id = (int)cmd.ExecuteScalar();
                }
            }

            return id;
        }

        public void AddSupplier(in SupplierModel model)
        {
            string query = "INSERT INTO " + Table.Supplier + " (";
            query += Table.SupplierColumn.SupplierName + ", ";
            query += Table.SupplierColumn.Phone + ") ";
            query += "VALUES (@SupplierName, @Phone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true.
                    cmd.Parameters.AddWithValue("@SupplierName", model.SupplierName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditSupplier(in SupplierModel model)
        {
            string query = "UPDATE " + Table.Supplier + " SET ";
            query += Table.SupplierColumn.SupplierName + " = @SupplierName, ";
            query += Table.SupplierColumn.Phone + " = @Phone ";
            query += "WHERE " + Table.SupplierColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@SupplierName", model.SupplierName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddTradeHistory_Stock(in StockModel model)
        {
            string query = "";

            query += "DECLARE @StockId INT; ";
            query += "SET @StockId = (SELECT " + Table.StockColumn.Id + " ";
            query += "FROM " + Table.Stock + " ";
            query += "WHERE " + Table.StockColumn.Id + " = @FK_StockId); ";

            query += "INSERT INTO " + Table.TradeHistory + " (";
            query += Table.TradeHistoryColumn.StockId + " ,";
            query += Table.TradeHistoryColumn.Total + " ,";
            query += Table.TradeHistoryColumn.Date + ") ";
            query += "VALUES (@StockId, @Total, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true.
                    cmd.Parameters.AddWithValue("@FK_StockId", model.Id);
                    cmd.Parameters.AddWithValue("@Total", model.StockPrice);
                    cmd.Parameters.AddWithValue("@Date", model.Date);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddTradeHistory_Sale(in SaleModel model)
        {
            string query = "";

            query += "DECLARE @SaleId INT; ";
            query += "SET @SaleId = (SELECT " + Table.SaleColumn.Id + " ";
            query += "FROM " + Table.Sale + " ";
            query += "WHERE " + Table.SaleColumn.Id + " = @FK_SaleId); ";

            query += "INSERT INTO " + Table.TradeHistory + " (";
            query += Table.TradeHistoryColumn.SaleId + " ,";
            query += Table.TradeHistoryColumn.Total + " ,";
            query += Table.TradeHistoryColumn.Date + ") ";
            query += "VALUES (@SaleId, @Total, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true.
                    cmd.Parameters.AddWithValue("@FK_SaleId", model.Id);
                    cmd.Parameters.AddWithValue("@Total", model.SalePrice);
                    cmd.Parameters.AddWithValue("@Date", model.Date);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRecord(in string table, in string primaryKeyLabel, in string primaryKey)
        {
            string query = "DELETE FROM " + table + " WHERE " + primaryKeyLabel + " = @" + primaryKeyLabel;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@" + primaryKeyLabel, primaryKey);

                    connection.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsDataUnique(in string table, in string dataLabel, in string data)
        {
            string query = "SELECT " + dataLabel + " FROM " + table + " WHERE " + dataLabel + " = @" + dataLabel;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@" + dataLabel + "", data);

                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public int CountDataEntry(in string table, in string columnLable, in string data)
        {
            int count = 0;

            string query = "SELECT COUNT(" + columnLable + ") FROM " + table;
            query += " WHERE " + columnLable + " = " + data;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }

            return count;
        }

        public List<PersonModel> GetAllPerson()
        {
            List<PersonModel> list = new List<PersonModel>();
            string query = " SELECT * FROM UserTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                PersonModel person = new PersonModel();
                                person.UserName = dr["Username"].ToString();
                                person.Password = dr["Password"].ToString();
                                person.FirstName = dr["FirstName"].ToString();
                                person.LastName = dr["LastName"].ToString();
                                person.Gender = char.Parse(dr["Gender"].ToString());
                                person.Age = int.Parse(dr["Age"].ToString());
                                person.Email = dr["Email"].ToString();
                                list.Add(person);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public List<CategoryModel> GetAllCategory()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            string query = "SELECT * FROM " + Table.ItemCategory;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                CategoryModel category = new CategoryModel();
                                category.Id = int.Parse(dr[Table.ItemCategoryColumn.Id].ToString());
                                category.CategoryName = dr[Table.ItemCategoryColumn.CategoryName].ToString();
                                list.Add(category);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public CategoryModel GetCategory(int id)
        {
            CategoryModel model = new CategoryModel();

            string query = "SELECT * FROM " + Table.ItemCategory;
            query += " WHERE " + Table.ItemCategoryColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.ItemCategoryColumn.Id].ToString());
                            model.CategoryName = dr[Table.ItemCategoryColumn.CategoryName].ToString();
                        }
                    }
                }
            }

            return model;
        }

        public List<SupplierModel> GetAllSupplier()
        {
            List<SupplierModel> list = new List<SupplierModel>();
            string query = "SELECT * FROM " + Table.Supplier;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                SupplierModel supplier = new SupplierModel();
                                supplier.Id = int.Parse(dr[Table.SupplierColumn.Id].ToString());
                                supplier.SupplierName = dr[Table.SupplierColumn.SupplierName].ToString();
                                supplier.Phone = int.Parse(dr[Table.SupplierColumn.Phone].ToString());
                                list.Add(supplier);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public List<CustomerModel> GetAllCustomer()
        {
            List<CustomerModel> list = new List<CustomerModel>();
            string query = "SELECT * FROM " + Table.Customer;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                CustomerModel cutomer = new CustomerModel();
                                cutomer.Id = int.Parse(dr[Table.CustomerColumn.Id].ToString());
                                cutomer.FirstName = dr[Table.CustomerColumn.FirstName].ToString();
                                cutomer.LastName = dr[Table.CustomerColumn.LastName].ToString();
                                cutomer.Phone = int.Parse(dr[Table.CustomerColumn.Phone].ToString());
                                list.Add(cutomer);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public SupplierModel GetSupplier(int id)
        {
            SupplierModel model = new SupplierModel();

            string query = "SELECT * FROM " + Table.Supplier;
            query += " WHERE " + Table.SupplierColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.SupplierColumn.Id].ToString());
                            model.SupplierName = dr[Table.SupplierColumn.SupplierName].ToString();
                            model.Phone = int.Parse(dr[Table.SupplierColumn.Phone].ToString());
                        }
                    }
                }
            }

            return model;
        }

        public CustomerModel GetCustomer(int id)
        {
            CustomerModel model = new CustomerModel();

            string query = "SELECT * FROM " + Table.Customer;
            query += " WHERE " + Table.CustomerColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.CustomerColumn.Id].ToString());
                            model.FirstName = dr[Table.CustomerColumn.FirstName].ToString();
                            model.LastName = dr[Table.CustomerColumn.LastName].ToString();
                            model.Phone = int.Parse(dr[Table.CustomerColumn.Phone].ToString());
                        }
                    }
                }
            }

            return model;
        }

        public StockModel GetStock(int id)
        {
            StockModel model = new StockModel();

            string query = "SELECT * FROM " + Table.Stock;
            query += " WHERE " + Table.StockColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.StockColumn.Id].ToString());
                            model.Supplier = GetSupplier(int.Parse(dr[Table.StockColumn.SupplierId].ToString()));
                            model.StockPrice = decimal.Parse(dr[Table.StockColumn.StockPrice].ToString());
                            model.Date = DateTime.Parse(dr[Table.StockColumn.Date].ToString());
                            model.Description = dr[Table.StockColumn.Description].ToString();
                        }
                    }
                }
            }

            return model;
        }

        public List<StockItemModel> GetStockItemList(int stockId)
        {
            List<StockItemModel> list = new List<StockItemModel>();

            string query = "SELECT * FROM " + Table.StockItem;
            query += " WHERE " + Table.StockItemColumn.StockId + " = @StockId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@StockId", stockId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                StockItemModel stockItem = new StockItemModel();
                                stockItem.Stock = GetStock(int.Parse(dr[Table.StockItemColumn.StockId].ToString()));
                                stockItem.Item = GetItem(int.Parse(dr[Table.StockItemColumn.ItemId].ToString()));
                                stockItem.ItemStockQuantity = int.Parse(dr[Table.StockItemColumn.ItemStockQuantity].ToString());
                                list.Add(stockItem);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public SaleModel GetSale(int id)
        {
            SaleModel model = new SaleModel();

            string query = "SELECT * FROM " + Table.Sale;
            query += " WHERE " + Table.SaleColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.SaleColumn.Id].ToString());
                            model.Customer = GetCustomer(int.Parse(dr[Table.SaleColumn.CustomerId].ToString()));
                            model.SalePrice = decimal.Parse(dr[Table.SaleColumn.SalePrice].ToString());
                            model.Date = DateTime.Parse(dr[Table.SaleColumn.Date].ToString());
                            model.Description = dr[Table.SaleColumn.Description].ToString();
                        }
                    }
                }
            }

            return model;
        }

        public List<SaleItemModel> GetSaleItemList(int saleId)
        {
            List<SaleItemModel> list = new List<SaleItemModel>();

            string query = "SELECT * FROM " + Table.SaleItem;
            query += " WHERE " + Table.SaleItemColumn.SaleId + " = @SaleId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@SaleId", saleId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                SaleItemModel saleItem = new SaleItemModel();
                                saleItem.Sale = GetSale(int.Parse(dr[Table.SaleItemColumn.SaleId].ToString()));
                                saleItem.Item = GetItem(int.Parse(dr[Table.SaleItemColumn.ItemId].ToString()));
                                saleItem.ItemSaleQuantity = int.Parse(dr[Table.SaleItemColumn.ItemSaleQuantity].ToString());
                                list.Add(saleItem);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public ItemModel GetItem(int id)
        {
            ItemModel model = new ItemModel();

            string query = "SELECT * FROM " + Table.Item;
            query += " WHERE " + Table.ItemColumn.Id + " = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            model.Id = int.Parse(dr[Table.ItemColumn.Id].ToString());
                            model.ItemName = dr[Table.ItemColumn.ItemName].ToString();
                            model.Category = GetCategory(int.Parse(dr[Table.ItemColumn.CategoryId].ToString()));
                            model.Supplier = GetSupplier(int.Parse(dr[Table.ItemColumn.SupplierId].ToString()));
                            model.Quantity = int.Parse(dr[Table.ItemColumn.Quantity].ToString());
                            model.UnitPrice = decimal.Parse(dr[Table.ItemColumn.UnitPrice].ToString());
                            model.Description = dr[Table.ItemColumn.Description].ToString();   
                        }
                    }
                }
            }

            return model;
        }

        public PersonModel GetPerson(string username)
        {
            PersonModel person = new PersonModel();
            string query = " SELECT * FROM " + Table.User;
            query += " WHERE " + Table.UserColumn.UserName + " = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            person.UserName = dr["Username"].ToString();
                            person.Password = dr["Password"].ToString();
                            person.FirstName = dr["FirstName"].ToString();
                            person.LastName = dr["LastName"].ToString();
                            person.Gender = char.Parse(dr["Gender"].ToString());
                            person.Age = int.Parse(dr["Age"].ToString());
                            person.Email = dr["Email"].ToString();
                        }
                    }
                }
            }

            return person;
        }

        public List<ItemModel> GetAllItem()
        {
            List<ItemModel> list = new List<ItemModel>();
            string query = "SELECT * FROM " + Table.Item;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                ItemModel item = new ItemModel();
                                item.Id = int.Parse(dr[Table.ItemColumn.Id].ToString());
                                item.ItemName = dr[Table.ItemColumn.ItemName].ToString();
                                item.Category = GetCategory(int.Parse(dr[Table.ItemColumn.CategoryId].ToString()));
                                item.Supplier = GetSupplier(int.Parse(dr[Table.ItemColumn.SupplierId].ToString()));
                                item.Quantity = int.Parse(dr[Table.ItemColumn.Quantity].ToString());
                                item.UnitPrice = decimal.Parse(dr[Table.ItemColumn.UnitPrice].ToString());
                                item.Description = dr[Table.ItemColumn.Description].ToString();
                                list.Add(item);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public List<TradeHistoryModel> GetAllTradeHistory()
        {
            List<TradeHistoryModel> list = new List<TradeHistoryModel>();
            string query = "SELECT * FROM " + Table.TradeHistory;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                TradeHistoryModel tradeHistory = new TradeHistoryModel();
                                tradeHistory.Id = int.Parse(dr[Table.ItemColumn.Id].ToString());

                                if(!dr.IsDBNull(dr.GetOrdinal(Table.TradeHistoryColumn.StockId)))
                                {
                                    tradeHistory.Stock = GetStock(int.Parse(dr[Table.TradeHistoryColumn.StockId].ToString()));
                                }
                                else
                                {
                                    tradeHistory.Sale = GetSale(int.Parse(dr[Table.TradeHistoryColumn.SaleId].ToString()));
                                }

                                tradeHistory.Total = decimal.Parse(dr[Table.TradeHistoryColumn.Total].ToString());
                                tradeHistory.Date = DateTime.Parse(dr[Table.TradeHistoryColumn.Date].ToString());
                                list.Add(tradeHistory);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public List<string> GetAllColmnValue(in string table, in string columnName)
        {
            List<string> list = new List<string>();

            string query = "SELECT " + columnName + " FROM " + table;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[columnName].ToString());
                            }
                        }
                    }
                }
            }

            return list;
        }

        public DataTable PopulateTable(in string table)
        {
            DataTable dt = new DataTable();
            string query = "";

            if(table == Table.Item)
            {
                query += "SELECT ";
                query += "item." + Table.ItemColumn.Id + ", ";
                query += "item." + Table.ItemColumn.ItemName + ", ";
                query += "category." + Table.ItemCategoryColumn.CategoryName + ", ";
                query += "supplier." + Table.SupplierColumn.SupplierName + ", ";
                query += "item." + Table.ItemColumn.Quantity + ", ";
                query += "item." + Table.ItemColumn.UnitPrice + ", ";
                query += "item." + Table.ItemColumn.Description + " ";
                query += "FROM " + Table.Item + " item ";
                query += "INNER JOIN " + Table.ItemCategory + " category ";
                query += "ON item." + Table.ItemColumn.CategoryId + " = category." + Table.ItemCategoryColumn.Id + " ";
                query += "INNER JOIN " + Table.Supplier + " supplier ";
                query += "ON item." + Table.ItemColumn.SupplierId + " = supplier." + Table.SupplierColumn.Id;
            }
            else
            {
                query = "SELECT * FROM " + table;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

    }
}
