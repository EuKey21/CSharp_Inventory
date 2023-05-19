using CSharp_Inventory;

namespace CSharp_inventory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Config.InitializeConnection(DatabaseType.Sql);
            Application.Run(new CustomersManagementForm());
        }
    }
}