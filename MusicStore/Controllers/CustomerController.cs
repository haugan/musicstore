using Microsoft.AspNetCore.Mvc;
using MusicStore.Models.ViewModels;
using MusicStore.Repositories.Interfaces;
using System;
using System.Linq;

namespace MusicStore.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            Console.WriteLine("debug: Constructing Customer controller (injecting registered dependencies..");
            this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(CustomerController));
        }

        public int PageSize { get; set; } = 5;

        public ViewResult List(int page = 1)
        {
            ViewBag.Title = $"Customer list (page {page})";

            var customers = customerRepository
                .Customers
                .OrderBy(c => c.CustomerID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);

            var pageInfo = new PageInfo
            {
                CurrentPage = page,
                ItemsOnPage = PageSize,
                ItemsInTotal = customerRepository.Customers.Count()
            };

            Console.WriteLine($"debug: Returning list of '{customers.Count()}' Customer(s)..");
            Console.WriteLine($"debug: Total number of Customers are '{pageInfo.ItemsInTotal}'");

            var customerList = new CustomerList
            {
                Customers = customers,
                PageInfo = pageInfo
            };

            return View(customerList);
        }
    }
}
