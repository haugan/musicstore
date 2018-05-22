using MusicStore.Models.DTOs;
using System.Linq;

namespace MusicStore.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        // Operations on this list triggers new query (e.g. to db)..
        // Could get heavy - cast to List or Array!

        IQueryable<Customer> Customers { get; }
    }
}
