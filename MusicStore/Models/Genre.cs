using System;

namespace MusicStore.Models
{
    public class Genre
    {
        public Genre(string name)
        {
            GenreID = new Random().Next();
            Name = name.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(name));
        }

        private int GenreID { get; }
        public string Name { get; set; }
    }
}
