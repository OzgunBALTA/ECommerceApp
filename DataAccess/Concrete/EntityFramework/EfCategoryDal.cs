using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ECommerceAppContext>, ICategoryDal
    {
    }
}
