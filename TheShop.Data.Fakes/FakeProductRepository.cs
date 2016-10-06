using FizzWare.NBuilder;
using System;
using System.Linq;
using System.Collections.Generic;
using TheShop.Domain.Core.Entities;
using TheShop.Domain.Core.Interfaces;
using TheShop.Domain.Core.Values;

namespace TheShop.Data.Fakes
{
    public class FakeProductRepository : IProductRepository
    {
        private readonly RandomGenerator _randomGenerator;
        public FakeProductRepository()
        {
            _randomGenerator = new RandomGenerator( (int)DateTime.Now.Ticks );
        }

        public IEnumerable<Product> GetByPartialName(string searchTerm)
        {
            return Builder<Product>
                .CreateListOfSize(200)
                .All().With(product => product.AskingPrice = new Price(_randomGenerator.Next(100m, 1000m)))
                .Build();
        }


        public IEnumerable<Product> GetLatest(int take, int skip)
        {
            return Builder<Product>
                .CreateListOfSize(take)
                .All().With(product => product.AskingPrice = new Price(_randomGenerator.Next(100, 1000)))
                .Build();
        }
    }
}
