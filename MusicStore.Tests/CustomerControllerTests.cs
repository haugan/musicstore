using Moq;
using MusicStore.Controllers;
using MusicStore.Models.DTOs;
using MusicStore.Models.ViewModels;
using MusicStore.Repositories.Interfaces;
using System.Linq;
using Xunit;

namespace MusicStore.Tests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Arrange:
            // Set size for pagination and expected number of returned customer items.
            // Configure mock repsitory and initialize it with objects.
            // Construct customer controller and feed it the queryable customer collection.
            var size = 2;
            var mock = new Mock<ICustomerRepository>();

            mock.Setup(r => r.Customers).Returns((new Customer[] {
                new Customer {CustomerID = 1},
                new Customer {CustomerID = 2},
                new Customer {CustomerID = 3},
                new Customer {CustomerID = 4},
            }).AsQueryable());

            var controller = new CustomerController(mock.Object)
            {
                PageSize = size
            };

            // Act:
            // Get second page of customers from the controller.
            var result = controller.List(size).ViewData.Model as CustomerList;
            var customers = result.Customers.ToArray();

            // Assert: 
            // If pagination works, the 2nd page of customers should contain a given # of items by set page size.
            // The items should be the 2nd and 4th from the mock list, and match on values (e.g. IDs).
            Assert.True(customers.Length == controller.PageSize);
            Assert.Equal(3, customers[0].CustomerID);
            Assert.Equal(4, customers[1].CustomerID);
        }
    }
}
