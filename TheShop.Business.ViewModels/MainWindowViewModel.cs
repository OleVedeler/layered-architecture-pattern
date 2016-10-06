using System.Collections.ObjectModel;
using TheShop.Domain.Core.Entities;
using TheShop.Domain.Core.Interfaces;

namespace TheShop.Business.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Product> _products;
        private readonly IProductSearchManager _productSearchManager;
        public MainWindowViewModel(IProductSearchManager productSearchManager)
        {
            _productSearchManager = productSearchManager;
        }


        public ObservableCollection<Product> Products
        {
            get 
            {
                if (_products == null)
                    LoadProducts();

                return _products; 
            }            
        }

        private void LoadProducts()
        {
            var productsFromRepository = _productSearchManager.GetRecent(10, 0);
            _products = new ObservableCollection<Product>();
            foreach(var product in productsFromRepository)
            {
                _products.Add(product);
            }
        }
        
    }
}
