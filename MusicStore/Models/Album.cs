using System;
using System.Collections.Generic;

namespace MusicStore.Models
{
    public class Album
    {
        public Album(string title, Cover cover, Artist artist, IEnumerable<Track> tracks, Genre genre, DateTime releaseDate)
        {
            AlbumID = new Random().Next();
            Title = title.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(title));
            Cover = cover;
            Artist = artist ?? throw new ArgumentNullException(nameof(artist));
            Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
            Genre = genre ?? throw new ArgumentNullException(nameof(genre));
            ReleaseDate = releaseDate;
            Sales = 0;
        }

        private int AlbumID { get; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public Artist Artist { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long Sales { get; set; }
    }
}
