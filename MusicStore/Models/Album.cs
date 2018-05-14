using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public Artist Artist { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public long Sales { get; set; }
    }
}
