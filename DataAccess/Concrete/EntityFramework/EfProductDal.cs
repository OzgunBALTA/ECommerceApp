using Core.DataAccess.Concrete;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceAppContext>, IProductDal
    {
        public async Task<List<Product>> GetAllWithCategoty(Expression<Func<Product, bool>> filter = null)
        {
            using (var context = new ECommerceAppContext())
            {
                return filter == null
                ? await context.Products.Include(x=>x.Category).ToListAsync()
                : await context.Products.Include(x => x.Category).Where(filter).ToListAsync();
            }
        }
    }
}
