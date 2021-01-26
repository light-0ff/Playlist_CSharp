using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    class MediaTrackModel : SQLiteTableManager
    {
        private SortedList<int, MediaTrackRecord> _mediaRecords;
        public MediaTrackModel(string dbPath) : base(dbPath)
        {
            this.CurrTableName = "MediaTracks";
            _mediaRecords = new SortedList<int, MediaTrackRecord>();
            getAllPlayListRecords();
        }
        public List<MediaTrackRecord> getRecordsFromPlayList(int id)
        {
            List<MediaTrackRecord> cList = new List<MediaTrackRecord>();
            foreach (MediaTrackRecord track in _mediaRecords.Values)
            {
                if(track.playlist_id == id)
                {
                    cList.Add(track);
                }
            }
            return cList;
        }
        private void getAllPlayListRecords()
        {
            Connection.Open();
            _command = new SQLiteCommand($"SELECT * FROM {this.CurrTableName}", _connection);
            SQLiteDataReader reader = _command.ExecuteReader();
            foreach (DbDataRecord name in reader)
            {
                _mediaRecords.Add(
                        Convert.ToInt32(name.GetValue(0).ToString()), 
                        new MediaTrackRecord (
                            Convert.ToInt32(name.GetValue(0).ToString()),
                            Convert.ToInt32(name.GetValue(1).ToString()),
                            name.GetValue(2).ToString(),
                            name.GetValue(3).ToString()
                        )
                );
            }
            Connection.Close();
        }
        public SortedList<int, MediaTrackRecord> MediaRecords
        {
            get
            {
                return _mediaRecords;
            }
        }

    }
}
