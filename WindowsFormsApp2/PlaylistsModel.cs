using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{


    class PlaylistsModel : SQLiteTableManager
    {
        private SortedList<int, string> _playlistNames;
        public PlaylistsModel(string dbPath) : base(dbPath)
        {
            this.CurrTableName = "Playlists";
            _playlistNames = new SortedList<int, string>();
            this.getPlayLists();
        }
        private void getPlayLists()
        {
            Connection.Open();
            _command = new SQLiteCommand($"SELECT * FROM {this.CurrTableName}", _connection);
            SQLiteDataReader reader = _command.ExecuteReader();
            foreach (DbDataRecord name in reader)
            {
                _playlistNames.Add(Convert.ToInt32(name.GetValue(0).ToString()), name.GetValue(1).ToString());
            }
            Connection.Close();
        }
        public SortedList<int, string> PlayLists
        {
            get
            {
                return _playlistNames;
            }
        }
        public bool addNewPlaylist(string plName)
        {
            int id = _playlistNames.Keys[_playlistNames.Count() - 1] + 1;
            if (this.ExecuteNonQuery($"INSERT INTO {this.CurrTableName} (id, playlist) VALUES ({id}, '{plName}')") == 1)
            {
                _playlistNames.Add(id, plName);
                return true;
            }
            return false;
        }
        public bool renameOldPlaylist(string oldPlName, string newPlName)
        {
            int id = _playlistNames.Keys[_playlistNames.Count() - 1] + 1;
            //if (this.ExecuteNonQuery($"UPDATE {this.CurrTableName} playlist = {newPlName}, WHERE name={oldPlName}") == 1)
            if (this.ExecuteNonQuery($"UPDATE {this.CurrTableName} SET playlist = '{newPlName}' WHERE playlist='{oldPlName}'") == 1)
            {

                foreach (KeyValuePair<int, string> item in _playlistNames)
                {
                    if (item.Value == oldPlName)
                    {
                        _playlistNames[item.Key] = newPlName;
                        break;
                    }
                }

                return true;
            }
            return false;
        }
    }
}
