using MusicStore.Models.DTOs;
using MusicStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Repositories
{
    public class ProductRepositoryFake : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { ProductID = 1, Name = "Product One", Category = "Category A", Price = 12.99M },
            new Product { ProductID = 2, Name = "Product Two", Category = "Category A", Price = 8.49M },
            new Product { ProductID = 3, Name = "Product Three", Category = "Category B", Price = 140.25M },
            new Product { ProductID = 4, Name = "Product Four", Category = "Category B", Price = 63.75M }


        }.AsQueryable<Product>();
    }
}
