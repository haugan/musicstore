using Microsoft.EntityFrameworkCore;
using System;

namespace MusicStore.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Console.WriteLine("debug: Constructing database context class..");
        }

        public DbSet<Models.DTOs.Customer> Customers { get; set; }
    }
}
