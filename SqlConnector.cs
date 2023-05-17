using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace CSharp_Inventory
{
    public class SqlConnector
    {
        private const string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection conn = new SqlConnection(db);
        public void AddPerson(PersonModel model)
        {
            conn.Open();

            var p = new DynamicParameters();
            p.Add("@Username", model.UserName);
            p.Add("@Password", model.Password);
            p.Add("@FirstName", model.FirstName);
            p.Add("@LastName", model.LastName);
            p.Add("@Gender", model.Gender);
            p.Add("@Age", model.Age);
            p.Add("@Email", model.Email);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            conn.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            MessageBox.Show("User Successfully Added");

            conn.Close();
        }
    }
}
