using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface IArtistRepository
    {
        IQueryable<Artist> Artists { get; }
    }
}
