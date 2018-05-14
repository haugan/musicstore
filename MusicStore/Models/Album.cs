﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Album
    {
        public Album(int albumID, string title, string cover, Artist artist, IEnumerable<Track> tracks, DateTime releaseDate, Genre genre, long sales)
        {
            AlbumID = albumID;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Cover = cover ?? throw new ArgumentNullException(nameof(cover));
            Artist = artist ?? throw new ArgumentNullException(nameof(artist));
            Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
            ReleaseDate = releaseDate;
            Genre = genre ?? throw new ArgumentNullException(nameof(genre));
            Sales = sales;
        }

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
