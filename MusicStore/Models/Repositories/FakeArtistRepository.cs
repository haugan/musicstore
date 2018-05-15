using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeArtistRepository : IArtistRepository
    {
        private readonly ILabelRepository labelRepo;

        public FakeArtistRepository(ILabelRepository labelRepo)
        {
            this.labelRepo = labelRepo;
        }

        public IQueryable<Artist> Artists => new List<Artist>
        {
            new Artist(labelRepo.Get("Pampa Records"), "DJ Koze")
            
        }.AsQueryable();
    }
}
