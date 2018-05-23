using MusicStore.Models.DTOs;
using MusicStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Repositories
{
    public class CustomerRepositoryFake : ICustomerRepository
    {
        public IQueryable<Customer> Customers => new List<Customer>
        {
            new Customer
            {
                CustomerID = 1,
                Email = "one@mail.net",
                FirstName = "One",
                LastName = "Eno",
                Gender = "Male",
                IPAddress = "22.22.22.22"
            },
            new Customer
            {
                CustomerID = 2,
                Email = "two@mail.net",
                FirstName = "Two",
                LastName = "Owt",
                Gender = "Male",
                IPAddress = "22.22.22.22"
            },
            new Customer
            {
                CustomerID = 3,
                Email = "three@mail.net",
                FirstName = "Three",
                LastName = "Eerht",
                Gender = "Female",
                IPAddress = "33.33.33.33"
            },

        }.AsQueryable<Customer>();
    }
}
