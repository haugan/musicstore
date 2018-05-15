using System;

namespace MusicStore.Models
{
    public class Version
    {
        public Version(string name)
        {
            VersionID = new Random().Next();
            Name = name.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(name));
        }

        private int VersionID { get; }
        public string Name { get; set; }
    }
}
