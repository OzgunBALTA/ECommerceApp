using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IResult> AddAsync(Product product);
        Task<IResult> DeleteAsync(Product product);
        Task<IResult> UpdateAsync(Product product);
        Task<IResult> ChangeStatusAsync(Product product);
        Task<IDataResult<Product>> GetByIdAsync(int id);
        Task<IDataResult<List<Product>>> GetAllAsync();
        Task<IDataResult<List<Product>>> GetProductsStatusTrueAsync();
        Task<IDataResult<List<Product>>> GetProductsStatusTrueByCategoryIdAsync(int id);
        Task<IDataResult<List<Product>>> GetByCategoryIdAsync(int id);
        Task<IDataResult<List<Product>>> GetAllWithCategoryAsync();
        Task<IDataResult<List<Product>>> GetProductsWithCategoryByCategoryIdAsync(int id);
    }
}
