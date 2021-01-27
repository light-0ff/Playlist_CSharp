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
    class SQLiteTableManager
    {
        private string _dbPath = "";
        protected SQLiteConnection _connection;
        private List<string> _tables;
        private string _currentTableName;
        protected SQLiteCommand _command;
        public string CurrTableName
        {
            get
            {
                return _currentTableName;
            }
            set
            {
                if (DoesTableExist(value))
                {
                    _currentTableName = value;
                }
                else
                {
                    throw new ArgumentException($"Table: {value} not exists");
                }
            }
        }
        public string DBPath
        {
            protected set
            {
                if (!File.Exists(value))
                {
                    File.Create(value); //создаем файл "базы данных"
                    //string createTables = File.ReadAllText(path);// создание-заполнение таблиц. находятся в файле Playlists.db.sql
                    string createTables = "BEGIN TRANSACTION;" +
                        "CREATE TABLE IF NOT EXISTS 'Playlists'(" +
                        "'id'    INTEGER NOT NULL UNIQUE," +
                        "'playlist'  TEXT NOT NULL," +
                        "PRIMARY KEY('id' AUTOINCREMENT)" +
                    "); " +
                    "CREATE TABLE IF NOT EXISTS 'MediaTracks'(" +
                        "'id'    INTEGER NOT NULL UNIQUE," +
                        "'playlist_id'   INTEGER NOT NULL," +
                        "'trackPath' TEXT NOT NULL," +
                        "'trackName' TEXT NOT NULL," +
                        "PRIMARY KEY('id' AUTOINCREMENT)" +
                   "); " +
                    "INSERT INTO 'Playlists'('id', 'playlist') VALUES"+
                        "(1, 'Default')," +
                        "(2, 'test');" +
                    "INSERT INTO 'MediaTracks'('id', 'playlist_id', 'trackPath', 'trackName') VALUES" +
                        "(1, 1, 'C:\\Users\\%USERPROFILE%\\desktop\\WindowsFormsApp2\\Sabaton - To Hell and back - Hobbit.mp4', 'Sabaton - To Hell and back - Hobbit')," +
                        "(2, 1, 'C:\\Users\\%USERPROFILE%\\Downloads\\video_(39).mp4', 'qwe')," +
                        "(3, 2, 'C:\\Users\\%USERPROFILE%\\desktop\\WindowsFormsApp2\\Sabaton - To Hell and back - Hobbit.mp4', 'asd')," +
                        "(4, 2, 'C:\\Users\\%USERPROFILE%\\desktop\\WindowsFormsApp2\\Sabaton - To Hell and back - Hobbit.mp4', 'zxc');" +
                    "COMMIT;";
                    ExecuteQuery(createTables);   //выполнить запрос
                    throw new FileNotFoundException();
                }
                _dbPath = value;
            }
            get
            {
                return _dbPath;
            }
        }
        public SQLiteTableManager(string dbPath)
        {
            DBPath = dbPath;
            _connection = new SQLiteConnection($"Data Source={_dbPath}; Version=3;");
            _tables = new List<string>();

            readTableNames();
        }
        public SQLiteConnection Connection
        {
            get
            {
                return _connection;
            }
        }
        private void readTableNames()
        {
            _connection.Open();
            String query = "SELECT name FROM sqlite_master WHERE type = " +
            "'table' AND name NOT LIKE 'sqlite_%'";
            _command = new SQLiteCommand(query, _connection);
            SQLiteDataReader reader = _command.ExecuteReader();
            foreach (DbDataRecord name in reader)
            {
                _tables.Add(name.GetValue(0).ToString());
            }
            _connection.Close();
            reader = null;
        }
        public bool DoesTableExist(string table)
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
        public SQLiteDataReader ExecuteQuery(string query)
        {
            Open();
            _command = new SQLiteCommand(query, _connection);
            SQLiteDataReader reader = _command.ExecuteReader();
            Close();
            return reader;
        }
        private bool IntToBool(int number)
        {
            return (number > 0 ? true : false);
        }
        public int ExecuteNonQuery(string query)
        {
            Open();
            _command = new SQLiteCommand(query, _connection);
            int result = _command.ExecuteNonQuery();
            Close();
            return result;
        }
        private void Open()
        {
            _connection.Open();
        }
        private void Close()
        {
            _connection.Close();
        }
    }
}
