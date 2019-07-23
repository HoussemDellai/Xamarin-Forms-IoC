using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProductsApp.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        private Product _product;

        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
