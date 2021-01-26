using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinFormApp
{
    class MediaTrackRecord
    {
        public int id;
        public int playlist_id;
        public string trackPath;
        public string trackName;
        public MediaTrackRecord(int id, int playlist_id, string trackPath, string trackName)
        {
            this.id = id;
            this.playlist_id = playlist_id;
            this.trackName = trackName;
            this.trackPath = trackPath;
        }
        public override string ToString()
        {
            return $"{trackName}";
        }
    }
}
