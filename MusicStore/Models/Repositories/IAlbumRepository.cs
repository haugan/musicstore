using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface IAlbumRepository
    {
        IQueryable<Album> Albums { get; }
    }
}
