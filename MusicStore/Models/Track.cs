using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Track
    {
        public int TrackID { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long Sales { get; set; }
    }
}
