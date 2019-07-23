using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Product product)
        {
            InitializeComponent();

            var vm = BindingContext as DetailsViewModel;

            vm.Product = product;
        }
    }
}