using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeGenreRepository : IGenreRepository
    {
        public IQueryable<Genre> Genres => new List<Genre>
        {
            new Genre()
            
        }.AsQueryable();
    }
}
