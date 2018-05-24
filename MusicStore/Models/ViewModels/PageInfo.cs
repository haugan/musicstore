using System;

namespace MusicStore.Models.ViewModels
{
    public class PageInfo
    {
        public int ItemsInTotal { get; set; }
        public int ItemsOnPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)ItemsInTotal / ItemsOnPage);
    }
}
