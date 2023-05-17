﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inventory
{
    public static class Config
    {
        // Set up textfile connection

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text= new TextConnector();
                Connection = text;
            }
        }

        public static string ConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fexke\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
