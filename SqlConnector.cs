﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSharp_Inventory
{
    public class SqlConnector : IDataConnection
    {
        private const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";


        public void AddPerson(PersonModel model)
        {
            string query = "INSERT INTO UserTable ";
            query += "(Username, Password, FirstName, LastName, Gender, Age, Email) ";
            query += "VALUES (@Username, @Password, @FirstName, @LastName, @Gender, @Age, @Email)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", model.UserName);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);

                    conn.Open();
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


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", model.UserName);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddCustomer(CustomerModel model)
        {
            string query = "INSERT INTO CustomerTable ";
            query += "(Firstname, Lastname, Phone) ";
            query += "VALUES (@FirstName, @LastName, @Phone)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Id is auto incremented in SQL by setting Identity to true.
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditCustomer(CustomerModel model)
        {
            string query = "UPDATE CustomerTable SET ";
            query += "FirstName = @FirstName, LastName = @LastName, Phone = @Phone ";
            query += "WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey)
        {
            string query = "DELETE FROM " + table + " WHERE " + primaryKeyLabel + " = @" + primaryKeyLabel;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@" + primaryKeyLabel + "", primaryKey);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsDataUnique(string table, string dataLabel, string data)
        {
            string query = "SELECT " + dataLabel + " FROM " + table + " WHERE " + dataLabel + " = @" + dataLabel;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@" + dataLabel + "", data);

                    conn.Open();

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

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
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

        public DataTable PopulateTable(string table)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + table;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
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
