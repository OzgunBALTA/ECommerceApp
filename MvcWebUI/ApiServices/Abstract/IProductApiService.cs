using MvcWebUI.Models;

namespace MvcWebUI.ApiServices.Abstract
{
    public interface IProductApiService
    {
        Task AddAsync(ProductModel productModel);
        Task DeleteAsync(int id);
        Task UpdateAsync(ProductModel productModel);
        Task ChangeStatusAsync(int id);
        Task<ProductModel> GetAsync(int id);
        Task<List<ProductModel>> GetAllAsync();
        Task<List<ProductModel>> GetProductsByCategoryIdAsync(int id);
        Task<List<ProductModel>> GetAllWithCategoryAsync();
        Task<List<ProductModel>> GetProductsWithCategoryByCategoryIdAsync(int id);
        Task<List<ProductModel>> GetProductsStatusTrue();
        Task<List<ProductModel>> GetProductsStatusTrueByCategoryIdAsync(int id);
    }
}
