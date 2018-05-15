using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeVersionRepository : IVersionRepository
    {
        public IQueryable<Version> Versions => new List<Version>
        {
            new Version()
            
        }.AsQueryable();
    }
}
