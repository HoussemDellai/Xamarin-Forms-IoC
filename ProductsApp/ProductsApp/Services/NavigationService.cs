using System.Linq;
using ProductsApp.Views;
using Xamarin.Forms;

namespace ProductsApp.Services
{
    public class NavigationService : INavigationService
    {
        public void GoToDetailsPage(Product product)
        {
            var page = GetCurrentPage();

            page.Navigation.PushAsync(new DetailsPage(product));
        }

        private Page GetCurrentPage()
        {
            return Application.Current.MainPage.Navigation
                .NavigationStack.LastOrDefault();
        }
    }
}
