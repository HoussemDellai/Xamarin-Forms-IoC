using ProductsApp.ViewModels;
using ProductsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;

            var vm = BindingContext as ProductsViewModel;

            vm?.GoToDetailsPage(product);

            //Navigation.PushAsync(new DetailsPage(product));
        }
    }
}