using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheShop.Domain.Core.Entities;
using TheShop.Domain.Core.Interfaces;

namespace TheShop.Business.Managers
{
    public class ProductSearchManager : IProductSearchManager
    {
        private ISearchTermValidator _searchTermValidator;
        private IProductRepository _productRepository;
        public ProductSearchManager(ISearchTermValidator searchTermValidator, IProductRepository productRepository)
        {
            _searchTermValidator = searchTermValidator;
            _productRepository = productRepository;
        }


        public IEnumerable<Product> SearchByName(string searchTerms)
        {
            if (!_searchTermValidator.IsValid(searchTerms))
                return new List<Product>();

            // log the search

            // do performance counting

            try
            {
                return _productRepository.GetByPartialName(searchTerms);

            }
            catch (Exception)
            {
                // Do something important with the exception, such as log it, retry-logic etc                
            }
            return new List<Product>();
        }


        public IEnumerable<Product> GetRecent(int take, int skip)
        {
            if (take >= 0 && skip >= 0)
                return _productRepository.GetLatest(take, skip);

            return new List<Product>();
        }
    }
}
