using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Task<IResult> AddAsync(Category category);
        Task<IResult> DeleteAsync(Category category);
        Task<IResult> UpdateAsync(Category category);
        Task<IResult> ChangeStatusAsync(Category category); 
        Task<IDataResult<Category>> GetByIdAsync(int id);
        Task<IDataResult<List<Category>>> GetAllAsync();
        Task<IDataResult<List<Category>>> GetCategoriesStatusTrueAsync();
    }
}
