using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        Task<List<Product>> GetAllWithCategoty(Expression<Func<Product, bool>> filter = null);
    }
}
