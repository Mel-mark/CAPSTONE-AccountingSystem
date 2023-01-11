using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace LoginForm.Class
{
    internal class Authentication
    {
        //Connection string
        public string connectionString { get; set; }
        string connection;

        public void getConnection()
        {
            connection = @"Data Source=Accounting.db; Version=3";
            connectionString = connection;
        }
        
        public void CreateDatabase()
        {
            if (!File.Exists("Accounting.db"))
            {
                try
                {
                    File.Create("Accounting.db");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CreateTable()
        {
            try
            {
                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    string query = @"CREATE TABLE Account (ID INTEGER PRIMARY KEY AUTOINCREMENT, FullName Text(25), Username Text(25), Password Text(25))";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }

  
}
