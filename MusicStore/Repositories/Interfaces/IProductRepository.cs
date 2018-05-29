using MusicStore.Models.DTOs;
using System.Linq;

namespace MusicStore.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
