using Microsoft.AspNetCore.Mvc;
using MusicStore.Repositories.Interfaces;

namespace MusicStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
    }
}
