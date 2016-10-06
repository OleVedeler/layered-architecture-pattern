using StructureMap.Configuration.DSL;
using TheShop.Business.Managers;
using TheShop.Business.ViewModels;
using TheShop.Data.Fakes;
using TheShop.Domain.Core.Interfaces;

namespace TheShopper.InversionOfControl
{
    public class RuntimeRegistry : Registry
    {
        public RuntimeRegistry()
        {
            For<IProductSearchManager>().Use<ProductSearchManager>();
            For<ISearchTermValidator>().Use<FakeSearchTermValidator>();
            For<IProductRepository>().Use<FakeProductRepository>();

            AddType(typeof(MainWindowViewModel), typeof(MainWindowViewModel));
        }
    }
}
