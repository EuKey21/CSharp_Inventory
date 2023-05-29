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
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";

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


        // TODO : Get all column values based on foreign key
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
