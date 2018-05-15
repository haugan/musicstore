using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface IGenreRepository
    {
        IQueryable<Genre> Genres { get; }
    }
}
