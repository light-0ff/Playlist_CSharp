using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    enum SQLiteDataTypes
    {
        INT,
        INTEGER,
        TINYINT,
        SMALLINT,
        MEDIUMINT,
        BIGINT,
        INT2,
        INT8,
        TEXT,
        CLOB,
        BLOB,
        NONE,
        REAL,
        DOUBLE,
        FLOAT,
        NUMERIC,
        BOOLEAN,
        DATE,
        DATETIME
    }
    class SQLiteColumn
    {
        private int _cid;
        private string _name;
        private SQLiteDataTypes _dataType;
        private bool _notNull = false;
        private string _defValue = "NULL";
        private bool _pk = false;
        private bool _unique = false;
        private bool _autoIncrement = false;

        public SQLiteColumn(int cid,string name,
            SQLiteDataTypes dataType,bool notNull,
            string defValue,bool unique,
            bool autoIncrement)
        {
            CID = cid;
            Name = name;
            DataType = dataType;
            IsNotNull = notNull;
            DefaultValue = defValue;
            IsUnique = unique;
            IsAutoIncrement = autoIncrement;
        }
        public int CID
        {
            get
            {
                return _cid;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException();
                }
                _cid = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public SQLiteDataTypes DataType
        {
            get
            {
                return _dataType;
            }
            private set
            {
                _dataType = value;
            }
        }
        public bool IsNotNull
        {
            get
            {
                return _notNull;
            }
            private set
            {
                _notNull = value;
            }
        }
        public string DefaultValue
        {
            get
            {
                return _defValue;
            }
            private set
            {
                _defValue = value;
            }
        }
        public bool IsPrimaryKey
        {
            get
            {
                return _pk;
            }
            private set
            {
                _pk = value;
            }
        }
        public bool IsUnique
        {
            get
            {
                return _unique;
            }
            private set
            {
                _unique = value;
            }
        }
        public bool IsAutoIncrement
        {
            get
            {
                return _autoIncrement;
            }
            private set
            {
                _autoIncrement = value;
            }

        }
        public override string ToString()
        {
            return $"SQLiteColumn";
        }
    }
}
