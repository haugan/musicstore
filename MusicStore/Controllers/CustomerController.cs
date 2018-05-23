using Microsoft.AspNetCore.Mvc;
using MusicStore.Repositories.Interfaces;
using System;

namespace MusicStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            Console.WriteLine("debug: Constructing Customer controller..");
            Console.WriteLine("debug: Injecting registered dependencies..");

            this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(CustomerController));
        }

        public ViewResult List()
        {
            Console.WriteLine("debug: Returning list of Customers..");

            ViewBag.Title = "Customer list";
            return View(customerRepository.Customers);
        }
    }
}
