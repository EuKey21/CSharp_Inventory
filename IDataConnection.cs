using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory
{
    public interface IDataConnection
    {
        void AddPerson(PersonModel model);

        bool IsDataUnique(string table, string dataLabel, string data);

        public List<PersonModel> GetAllPerson();

        public DataTable PopulatePersonTable();

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey);
    }
}
