using System.Linq;

namespace MusicStore.Models.Repositories
{
    public interface ILabelRepository
    {
        IQueryable<Label> Labels { get; }
        Label Get(string name);
    }
}
