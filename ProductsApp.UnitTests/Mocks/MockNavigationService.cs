using ProductsApp.Services;

namespace ProductsApp.UnitTests.Mocks
{
    public class MockNavigationService : INavigationService
    {
        public bool IsNavigated { get; set; }

        public void GoToDetailsPage(Product product)
        {
            IsNavigated = true;
        }
    }
}
