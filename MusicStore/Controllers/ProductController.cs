using System;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Repositories.Interfaces;

namespace MusicStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            Console.WriteLine("debug: Constructing Product controller (injecting registered dependencies..");
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public ViewResult List => View(productRepository.Products);
    }
}
