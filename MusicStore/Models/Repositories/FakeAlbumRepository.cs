using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeAlbumRepository : IAlbumRepository
    {
        public IQueryable<Album> Albums => new List<Album>
        {
            new Album()
            
        }.AsQueryable();
    }
}
