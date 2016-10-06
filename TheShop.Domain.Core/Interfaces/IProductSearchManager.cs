using System.Collections.Generic;
using TheShop.Domain.Core.Entities;

namespace TheShop.Domain.Core.Interfaces
{
    public interface IProductSearchManager
    {
        IEnumerable<Product> SearchByName(string searchTerms);

        IEnumerable<Product> GetRecent(int take, int skip);
    }
}
