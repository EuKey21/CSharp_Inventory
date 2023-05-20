using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Inventory.Models;

namespace CSharp_Inventory.DataProcessing
{
    public class TextConnector : IDataConnection
    {
        public void AddCategory(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public void EditCustomer(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public void EditPerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public bool IsDataUnique(string table, string dataLabel, string data)
        {
            throw new NotImplementedException();
        }

        public DataTable PopulateTable(string table)
        {
            throw new NotImplementedException();
        }
    }
}
