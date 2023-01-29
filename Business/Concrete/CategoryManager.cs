using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<IResult> AddAsync(Category category)
        {
            await _categoryDal.AddAsync(category);
            return new SuccessResult();
        }

        public async Task<IResult> ChangeStatusAsync(Category category)
        {
            category.Status = !category.Status;
            await _categoryDal.UpdateAsync(category);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Category category)
        {
            await _categoryDal.DeleteAsync(category);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Category>>> GetAllAsync()
        {
            var categories = await _categoryDal.GetAllAsync();
            return new SuccessDataResult<List<Category>>(categories);
        }

        public async Task<IDataResult<Category>> GetByIdAsync(int id)
        {
            var category = await _categoryDal.GetAsync(x => x.CategoryId == id);
            return new SuccessDataResult<Category>(category);
        }

        public async Task<IDataResult<List<Category>>> GetCategoriesStatusTrueAsync()
        {
            var categories = await _categoryDal.GetAllAsync(x => x.Status == true);
            return new SuccessDataResult<List<Category>>(categories);
        }

        public async Task<IResult> UpdateAsync(Category category)
        {
            await _categoryDal.UpdateAsync(category);
            return new SuccessResult();
        }
    }
}
