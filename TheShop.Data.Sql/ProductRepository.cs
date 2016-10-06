using System.Collections.Generic;
using TheShop.Domain.Core.Entities;
using TheShop.Domain.Core.Interfaces;

namespace TheShop.Data.Sql
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetByPartialName(string searchTerm)
        {
            string sql = "SELECT * FROM PRODUCTS WHERE NAME LIKE '%" + searchTerm + "%'";

            return new List<Product>();
        }


        public IEnumerable<Product> GetLatest(int take, int skip)
        {
            throw new System.NotImplementedException();
        }
    }
}
