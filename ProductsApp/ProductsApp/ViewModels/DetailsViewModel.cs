using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FluentValidation.Results;
using ProductsApp.Validators;
using Xamarin.Forms;

namespace ProductsApp.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        private Product _product;
        private string _error;

        public Product Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged();
            }
        }

        public string Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged();
            }
        }

        public ICommand ValidateCommand => new Command(Validate);

        public void Validate()
        {
            var validator = new ProductValidator();

            var result = validator.Validate(Product);

            Error = result.IsValid ? string.Empty : "Data is not valid.";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
