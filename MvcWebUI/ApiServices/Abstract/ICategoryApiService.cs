using MvcWebUI.Models;

namespace MvcWebUI.ApiServices.Abstract
{
    public interface ICategoryApiService
    {
        Task AddAsync(CategoryModel categoryModel);
        Task DeleteAsync(int id);
        Task UpdateAsync(CategoryModel categoryModel);
        Task ChangeStatusAsync(int id);
        Task<CategoryModel> GetAsync(int id);
        Task<List<CategoryModel>> GetAllAsync();
        Task<List<CategoryModel>> GetCategoriesStatusTrueAsync();
    }
}
