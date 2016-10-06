
namespace TheShop.Domain.Core.Interfaces
{
    public interface ICanValidate<TEntity> where TEntity : class
    {
        bool IsValid(TEntity entityToValidate);
    }
}
