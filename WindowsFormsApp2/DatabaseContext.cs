using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    public enum SQLiteMode
    {
        NEW,
        EXIST
    }
    public class DatabaseContext
    {
        private static string _dbPath = "";
        private static SQLiteConnection _connection;
        private static List<string> _tables;
        public static SQLiteConnection Connection
        {
            get
            {
                return _connection;
            }
        }
        public static string DBPath
        {
            get
            {
                return _dbPath;
            }
        }
        public DatabaseContext(string dbPath, SQLiteMode mode)
        {
            switch (mode)
            {
                case SQLiteMode.NEW:
                    {
                        SQLiteConnection.CreateFile(dbPath);

                        break;
                    }
                case SQLiteMode.EXIST:
                    {
                        if (!File.Exists(dbPath))
                        {
                            throw new FileNotFoundException();
                        }
                        break;
                    }
                default:
                    break;
            }
            _dbPath = dbPath;
            _connection = new SQLiteConnection(
                $"Data Source={dbPath}; Version=3;");
            _tables = new List<string>();
            Init();
        }

        private static void Init()
        {
            readTableNames();
            //readFieldNames();
        }
        public static bool DoesTableExist(string table)
        {
            if (_tables.Count < 1)
            {
                readTableNames();
            }
            if (_tables.Count < 1)
            {
                throw new Exception("Database is empty.");
            }
            foreach (string name in _tables)
            {
                if (name.Equals(table))
                {
                    return true;
                }
            }
            return false;
        }

        private static void readTableNames()
        {
            _connection.Open();
            String query = "SELECT name FROM sqlite_master WHERE type = " +
            "'table' AND name NOT LIKE 'sqlite_%'";
            SQLiteCommand command = new SQLiteCommand(
                query, _connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord name in reader)
            {
                _tables.Add(name.GetValue(0).ToString());
            }
            _connection.Close();
        }
        /*
        private void readFieldNames()
        {
            foreach (string table in TablesList)
            {
                readTableFieldNames(table);
            }

        }
        private void readTableFieldNames(string table)
        {
            _connection.Open();
            SQLiteCommand command;
            String query = $"SELECT name FROM PRAGMA_TABLE_INFO(" +
                $"'{table}')";
            command = new SQLiteCommand(
            query, _connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord name in reader)
            {
                _tables[table].Add(name.GetValue(0).ToString());
            }
            _connection.Close();
        }*/

        public static List<String> TablesList
        {
            get
            {
                return _tables;
            }
        }
        /*
        public List<string> getFields(string table)
        {
            if (_tables.ContainsKey(table))
            {
                return _tables[table];
            }
            else
            {
                throw new ArgumentException();
            }
        }
        */
        public override string ToString()
        {
            string data = "DatabaseContext => {\n" +
                $"\tPath: {Path.GetFileName(_dbPath)};\n" +
                $"\tTablesCount: {TablesList.Count};\n";
            /*foreach (string table in TablesList)
            {
                data +=
            }*/
            return data;
        }
    }
}
