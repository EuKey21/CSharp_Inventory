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
        private const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void AddPerson(PersonModel model)
        {
            string query = "INSERT INTO UserTable ";
            query += "(Username, Password, FirstName, LastName, Gender, Age, Email) ";
            query += "VALUES (@Username, @Password, @FirstName, @LastName, @Gender, @Age, @Email)";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void EditPerson(PersonModel model)
        {
            string query = "UPDATE UserTable SET ";
            query += "Password = @Password, FirstName = @FirstName, LastName = @LastName, ";
            query += "Gender = @Gender, Age = @Age, Email = @Email ";
            query += "WHERE Username = @Username";


            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void AddCustomer(CustomerModel model)
        {
            string query = "INSERT INTO CustomerTable ";
            query += "(Firstname, Lastname, Phone) ";
            query += "VALUES (@FirstName, @LastName, @Phone)";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void EditCustomer(CustomerModel model)
        {
            string query = "UPDATE CustomerTable SET ";
            query += "FirstName = @FirstName, LastName = @LastName, Phone = @Phone ";
            query += "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void AddCategory(CategoryModel model)
        {
            string query = "INSERT INTO ItemCategoryTable ";
            query += "(CategoryName) VALUES (@CategoryName)";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void EditCategory(CategoryModel model)
        {
            string query = "UPDATE ItemCategoryTable SET ";
            query += "CategoryName = @CategoryName WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void AddItem(ItemModel model)
        {
            string query = "INSERT INTO ItemTable ";
            query += "(ItemName, Quantity, Price, Category, Description) ";
            query += "VALUES (@ItemName, @Quantity, @Price, @Category, @Description)";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Id is auto incremented in SQL by setting Identity to true
                    cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                    cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                    cmd.Parameters.AddWithValue("@Price", model.Price);
                    cmd.Parameters.AddWithValue("@Category", model.Category);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditItem(ItemModel model)
        {
            string query = "UPDATE ItemTable SET ";
            query += "ItemName = @ItemName, Quantity = @Quantity, Price = @Price, Category = @Category, Description = @Description ";
            query += "WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                    cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                    cmd.Parameters.AddWithValue("@Price", model.Price);
                    cmd.Parameters.AddWithValue("@Category", model.Category);
                    cmd.Parameters.AddWithValue("@Description", model.Description);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddSupplier(SupplierModel model)
        {
            string query = "INSERT INTO SupplierTable ";
            query += "(SupplierName, Phone) ";
            query += "VALUES (@SupplierName, @Phone)";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void EditSupplier(SupplierModel model)
        {
            string query = "UPDATE SupplierTable SET ";
            query += "SupplierName = @SupplierName, Phone = @Phone ";
            query += "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey)
        {
            string query = "DELETE FROM " + table + " WHERE " + primaryKeyLabel + " = @" + primaryKeyLabel;

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@" + primaryKeyLabel + "", primaryKey);

                    connection.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsDataUnique(string table, string dataLabel, string data)
        {
            string query = "SELECT " + dataLabel + " FROM " + table + " WHERE " + dataLabel + " = @" + dataLabel;

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public List<PersonModel> GetAllPerson()
        {
            List<PersonModel> list = new List<PersonModel>();
            string query = " SELECT * FROM UserTable";

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public List<string> GetAllColmnValue(string table, string columnName)
        {
            List<string> list = new List<string>();

            string query = "SELECT " + columnName + " FROM " + table;

            using (SqlConnection connection = new SqlConnection(connStr))
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

        public DataTable PopulateTable(string table)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + table;

            using (SqlConnection connection = new SqlConnection(connStr))
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
