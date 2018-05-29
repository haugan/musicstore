using MusicStore.Models.DTOs;
using System.Linq;

namespace MusicStore.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Customers { get; }
    }
}
