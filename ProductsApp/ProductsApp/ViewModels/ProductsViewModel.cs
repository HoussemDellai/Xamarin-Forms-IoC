using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ProductsApp.Services;

namespace ProductsApp.ViewModels
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        private List<Product> _products;

        public List<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public ProductsViewModel(IDataService dataService, 
                                 INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            InitializeData();
        }

        private async Task InitializeData()
        {
            Products = await _dataService.GetProducts();
        }

        public void GoToDetailsPage(Product product)
        {
            _navigationService.GoToDetailsPage(product);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
