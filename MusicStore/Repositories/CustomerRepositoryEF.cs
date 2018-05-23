using MusicStore.Contexts;
using MusicStore.Repositories.Interfaces;
using System;
using System.Linq;

namespace MusicStore.Repositories
{
    public class CustomerRepositoryEF : ICustomerRepository
    {
        private readonly ApplicationDbContext context;

        public CustomerRepositoryEF(ApplicationDbContext context)
        {
            Console.WriteLine("debug: Constructing customer repository (EF)..");

            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<Models.DTOs.Customer> Customers => context.Customers;
    }
}
