using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface ITrackRepository
    {
        IQueryable<Track> Tracks { get; }
    }
}
