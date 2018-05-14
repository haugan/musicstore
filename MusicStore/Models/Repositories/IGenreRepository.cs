using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.Repositories
{
    public interface IGenreRepository
    {
        IQueryable<Genre> Genres { get; }
    }
}
