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

namespace CSharp_Inventory
{
    public class SqlConnector : IDataConnection
    {
        private const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";


        public void AddPerson(PersonModel model)
        {
            string query = "INSERT INTO ";
            query += "UserTable (Username, Password, FirstName, LastName, Gender, Age, Email) ";
            query += "VALUES (@Username, @Password, @FirstName, @LastName, @Gender, @Age, @Email)";

            using (SqlConnection conn = new SqlConnection(connStr))
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

                MessageBox.Show("User Successfully Added");
            }
        }

        public bool IsDataUnique(string table, string dataLabel, string data)
        {
            string query = "SELECT " + dataLabel + " FROM " + table + " WHERE " + dataLabel + " = @" + dataLabel;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@"+ dataLabel + "", data);

                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return false;            
                    }
                }
            }
            return true;
        }
    }
}
