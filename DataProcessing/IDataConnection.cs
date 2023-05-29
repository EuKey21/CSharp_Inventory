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
        void AddPerson(in PersonModel model);

        public void EditPerson(in PersonModel model);

        public void AddCustomer(in CustomerModel model);

        public void EditCustomer(in CustomerModel model);

        public void AddCategory(in CategoryModel model);

        public void EditCategory(in CategoryModel model);

        public void AddItem(in ItemModel model);

        public void EditItem(in ItemModel model);

        public void AddSupplier(in SupplierModel model);

        public void EditSupplier(in SupplierModel model);

        bool IsDataUnique(in string table, in string dataLabel, in string data);

        public List<PersonModel> GetAllPerson();

        public List<CategoryModel> GetAllCategory();

        public List<SupplierModel> GetAllSupplier();

        public List<string> GetAllColmnValue(in string table, in string columnName);

        public DataTable PopulateTable(in string table);

        public void DeleteRecord(in string table, in string primaryKeyLabel, in string primaryKey);
    }
}
