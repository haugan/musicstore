using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Models.Repositories
{
    public class FakeTrackRepository : ITrackRepository
    {
        private readonly IArtistRepository artistRepo;

        public FakeTrackRepository(IArtistRepository artistRepo)
        {
            this.artistRepo = artistRepo;
        }

        public IQueryable<Track> Tracks => new List<Track>
        {
            new Track(artistRepo.Get("DJ Koze"))
            
        }.AsQueryable();
    }
}
