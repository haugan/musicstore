using System;

namespace MusicStore.Models
{
    public class Track
    {
        public Track(Artist artist, Label label, Genre genre, Version version, int bpm, Key key, DateTime releaseDate, string title, string length)
        {
            TrackID = new Random().Next();
            Artist = artist ?? throw new ArgumentNullException(nameof(artist));
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Genre = genre ?? throw new ArgumentNullException(nameof(genre));
            Version = version ?? throw new ArgumentNullException(nameof(version));
            BPM = bpm;
            Key = key ?? throw new ArgumentNullException(nameof(key));
            ReleaseDate = releaseDate;
            Title = title.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(title));
            Length = length.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(length));
            Sales = 0;
        }

        private int TrackID { get; }
        public Artist Artist { get; set; }
        public Label Label { get; set; }
        public Genre Genre { get; set; }
        public Version Version { get; set; }
        public int BPM { get; set; }
        public Key Key { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }
        public long Sales { get; set; }
    }
}
