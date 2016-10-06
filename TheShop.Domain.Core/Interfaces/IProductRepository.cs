using System.Collections.Generic;
using TheShop.Domain.Core.Entities;

namespace TheShop.Domain.Core.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByPartialName(string searchTerm);

        IEnumerable<Product> GetLatest(int take, int skip);
    }
}
