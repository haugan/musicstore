﻿using System;

namespace MusicStore.Models
{
    public class Artist
    {
        public Artist(string name)
        {
            ArtistID = new Random().Next();
            Name = name.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(name));
            Sales = 0;
        }

        private int ArtistID { get; }
        public string Name { get; set; }
        public long Sales { get; set; }
    }
}
