using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsApp.Services
{
    public interface IDataService
    {
        Task<List<Product>> GetProducts();
    }
}
