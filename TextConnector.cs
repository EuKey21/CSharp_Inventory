using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory
{
    public class TextConnector : IDataConnection
    {
        public void AddPerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(string table, string primaryKeyLabel, string primaryKey)
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

        public DataTable PopulatePersonTable()
        {
            throw new NotImplementedException();
        }
    }
}
