using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    class SQLiteRow
    {
        private ArrayList _cells;
        public SQLiteRow(int fieldsCount)
        {
            _cells = new ArrayList(fieldsCount);
        }
        public object this[int index]
        {
            get
            {
                return _cells[index];
            }
            set
            {
                _cells[index] = value;
            }
        }

    }
}
