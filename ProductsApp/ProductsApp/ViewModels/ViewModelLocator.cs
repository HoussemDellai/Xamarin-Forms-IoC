using CommonServiceLocator;

namespace ProductsApp.ViewModels
{
    public class ViewModelLocator
    {
        public ProductsViewModel ProductsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProductsViewModel>();
            }
        }
    }
}
