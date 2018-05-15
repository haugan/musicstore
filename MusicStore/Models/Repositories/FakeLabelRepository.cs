using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeLabelRepository : ILabelRepository
    {
        public IQueryable<Label> Labels => new List<Label>
        {
            new Label("Pampa Records")
            
        }.AsQueryable();

        public Label Get(string name) => Labels.Single(l => l.Equals(name));
    }
}
