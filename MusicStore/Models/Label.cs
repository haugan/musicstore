using System;

namespace MusicStore.Models
{
    public class Label
    {
        public Label(string name)
        {
            LabelID = new Random().Next();
            Name = name.ToUpper().Trim() ?? throw new ArgumentNullException(nameof(name));
        }

        private int LabelID { get; }
        public string Name { get; set; }
    }
}
