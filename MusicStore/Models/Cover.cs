using System;

namespace MusicStore.Models
{
    public class Cover
    {
        public Cover(string filename)
        {
            CoverID = new Random().Next();
            Filename = filename.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(filename));
        }

        public int CoverID { get; set; }
        public string Filename { get; set; }
    }
}
