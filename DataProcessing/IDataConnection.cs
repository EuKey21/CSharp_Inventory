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
        bool ValidateLogin(string username, string password);
        void AddPerson(in PersonModel model);

        void EditPerson(in PersonModel model);

        void AddCustomer(in CustomerModel model);

        void EditCustomer(in CustomerModel model);

        void AddCategory(in CategoryModel model);

        void EditCategory(in CategoryModel model);

        void AddItem(in ItemModel model);

        void EditItem(in ItemModel model);

        void UpdateItem_Quantity(in ItemModel model, in decimal newQuantity);

        void AddStockItem(in StockItemModel model);

        int AddStock(in StockModel model);

        void AddSaleItem(in SaleItemModel model);

        int AddSale(in SaleModel model);

        void AddSupplier(in SupplierModel model);

        void EditSupplier(in SupplierModel model);

        void AddTradeHistory_Stock(in StockModel model);

        void AddTradeHistory_Sale(in SaleModel model);

        bool IsDataUnique(in string table, in string dataLabel, in string data);

        int CountDataEntry(in string table, in string columnLable, in string data);

        List<PersonModel> GetAllPerson();

        List<CategoryModel> GetAllCategory();

        CategoryModel GetCategory(int id);

        List<SupplierModel> GetAllSupplier();

        List<CustomerModel> GetAllCustomer();

        SupplierModel GetSupplier(int id);

        CustomerModel GetCustomer(int id);

        StockModel GetStock(int id);

        List<StockItemModel> GetStockItemList(int stockId);

        SaleModel GetSale(int id);

        List<SaleItemModel> GetSaleItemList(int saleId);

        ItemModel GetItem(int id);

        PersonModel GetPerson(string username);

        List<TradeHistoryModel> GetAllTradeHistory();

        List<ItemModel> GetAllItem();

        List<string> GetAllColmnValue(in string table, in string columnName);

        DataTable PopulateTable(in string table);

        void DeleteRecord(in string table, in string primaryKeyLabel, in string primaryKey);
    }
}
