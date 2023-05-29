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

        void EditPerson(in PersonModel model);

        void AddCustomer(in CustomerModel model);

        void EditCustomer(in CustomerModel model);

        void AddCategory(in CategoryModel model);

        void EditCategory(in CategoryModel model);

        void AddItem(in ItemModel model);

        void EditItem(in ItemModel model);

        void AddSupplier(in SupplierModel model);

        void EditSupplier(in SupplierModel model);

        bool IsDataUnique(in string table, in string dataLabel, in string data);

        int CountDataEntry(in string table, in string columnLable, in string data);

        List<PersonModel> GetAllPerson();

        List<CategoryModel> GetAllCategory();

        List<SupplierModel> GetAllSupplier();

        List<string> GetAllColmnValue(in string table, in string columnName);

        DataTable PopulateTable(in string table);

        void DeleteRecord(in string table, in string primaryKeyLabel, in string primaryKey);
    }
}
