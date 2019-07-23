using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsApp.Services
{
    public class DataService : IDataService
    {
        public async Task<List<Product>> GetProducts()
        {
            await Task.Delay(500);

            return new List<Product>
            {
                new Product { Name = "XBOX-1", Cost = 4001, Description = "Gaming console 1" },
                new Product { Name = "XBOX-2", Cost = 4002, Description = "Gaming console 2" },
                new Product { Name = "XBOX-3", Cost = 4003, Description = "Gaming console 3" },
                new Product { Name = "XBOX-4", Cost = 4004, Description = "Gaming console 4" },
                new Product { Name = "XBOX-5", Cost = 4005, Description = "Gaming console 5" },
                new Product { Name = "XBOX-6", Cost = 4006, Description = "Gaming console 6" },
                new Product { Name = "XBOX-7", Cost = 4007, Description = "Gaming console 7" },
                new Product { Name = "XBOX-8", Cost = 4008, Description = "Gaming console 8" },
                new Product { Name = "XBOX-9", Cost = 4009, Description = "Gaming console 9" },
                new Product { Name = "XBOX-10", Cost = 4010, Description = "Gaming console 10" },
                new Product { Name = "XBOX-11", Cost = 4011, Description = "Gaming console 11" },
            };
        }
    }
}
