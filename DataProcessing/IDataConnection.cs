using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Inventory.Models;

namespace CSharp_Inventory.DataProcessing
{
    public interface IDataConnection
    {
        void AddPerson(PersonModel model);

        public void EditPerson(PersonModel model);

        public void AddCustomer(CustomerModel model);

        public void EditCustomer(CustomerModel model);

        bool IsDataUnique(string table, string dataLabel, string data);

        public List<PersonModel> GetAllPerson();

        public DataTable PopulateTable(string table);

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey);
    }
}
