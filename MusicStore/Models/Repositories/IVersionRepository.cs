using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface IVersionRepository
    {
        IQueryable<Version> Versions { get; }
    }
}
