using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    class SQLiteTable
    {
        private String _name;
        private SortedList<string, SQLiteColumn> _columns;
        private List<SQLiteRow> _rows;

        public SQLiteTable(string name)
        {
            Name = name;
            _columns = new SortedList<string, SQLiteColumn>();
            _rows = new List<SQLiteRow>();
        }
        private int GetCID(string cName)
        {
            if (_columns.ContainsKey(cName))
            {
                return _columns[cName].CID;
            }
            throw new IndexOutOfRangeException();
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (DatabaseContext.DoesTableExist(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private void InitColumns()
        {
            /*DatabaseContext.Connection.Open();
            String query = $"PRAGMA table_info({Name});";
            SQLiteCommand command = new SQLiteCommand(
                query, DatabaseContext.Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord row in reader)
            {
                SQLiteDataTypes dt = SQLiteDataTypes["INTEGER"];
                _columns.Add(row.GetValue(1).ToString(),
                    new SQLiteColumn(
                        row.GetValue(0).ToString(),
                        row.GetValue(1).ToString(),
                        row.
                        ))
            }
            DatabaseContext.Connection.Close();*/
        }
        

        public object this[int rowNumber, string columnName]
        {
            get
            {
                return _rows[rowNumber][GetCID(columnName)];
            }
            set
            {
                _rows[rowNumber][GetCID(columnName)] = value;
            }
        }
        /*public void AddRow()
        {
            _rows.Add(new SQLiteRow(_columns.Count));
        }*/
    }
}
