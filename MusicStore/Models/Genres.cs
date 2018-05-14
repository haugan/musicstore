using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Genre
    {
        public Genre(int genreID, string name)
        {
            GenreID = genreID;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}
