using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.Services;

namespace ProductsApp.UnitTests.Mocks
{
    public class MockDataService : IDataService
    {
        public async Task<List<Product>> GetProducts()
        {
            return new List<Product>
            {
                new Product { Name = "XBOX-1-Mock", Cost = 4001, Description = "Gaming console 1" },
                new Product { Name = "XBOX-2-Mock", Cost = 4002, Description = "Gaming console 2" },
                new Product { Name = "XBOX-3-Mock", Cost = 4003, Description = "Gaming console 3" },
            };
        }
    }
}
