using System.Collections.Generic;

namespace MusicStore.Models.ViewModels
{
    public class CustomerList
    {
        public IEnumerable<DTOs.Customer> Customers { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
