using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Track
    {
        public Track(int trackID, string title, string length, DateTime releaseDate, long sales)
        {
            TrackID = trackID;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Length = length ?? throw new ArgumentNullException(nameof(length));
            ReleaseDate = releaseDate;
            Sales = sales;
        }

        public int TrackID { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long Sales { get; set; }
    }
}
