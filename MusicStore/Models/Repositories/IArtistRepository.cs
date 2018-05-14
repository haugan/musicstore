using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.Repositories
{
    public interface IArtistRepository
    {
        IQueryable<Artist> Artists { get; }
    }
}
