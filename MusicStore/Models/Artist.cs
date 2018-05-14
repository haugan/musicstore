using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Artist
    {
        public Artist(int artistID, string name, IEnumerable<Track> tracks, IEnumerable<Album> albums, long sales)
        {
            ArtistID = artistID;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
            Albums = albums ?? throw new ArgumentNullException(nameof(albums));
            Sales = sales;
        }

        public int ArtistID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public long Sales { get; set; }
    }
}
