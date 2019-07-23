using ProductsApp.UnitTests.Mocks;
using ProductsApp.ViewModels;
using Xunit;

namespace ProductsApp.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void NavigationTest()
        {
            // Arrange
            var mockDataService = new MockDataService();
            var mockNavigationService = new MockNavigationService();
            var vm = new ProductsViewModel(mockDataService, mockNavigationService);

            // Act
            vm.GoToDetailsPage(new Product());

            // Assert
            Assert.True(mockNavigationService.IsNavigated);
        }

        [Fact]
        public void InitializeDataTest()
        {
            // Arrange
            var mockDataService = new MockDataService();
            var mockNavigationService = new MockNavigationService();

            // Act
            var vm = new ProductsViewModel(mockDataService, mockNavigationService);

            // Assert
            Assert.True(vm.Products.Count == 3);
        }
    }
}
