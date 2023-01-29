using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<IResult> AddAsync(Product product)
        {
            await _productDal.AddAsync(product);
            return new SuccessResult();
        }

        public async Task<IResult> ChangeStatusAsync(Product product)
        {
            product.Status = !product.Status;
            await _productDal.UpdateAsync(product);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Product product)
        {
            await _productDal.DeleteAsync(product);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {
            var products = await _productDal.GetAllAsync();
            return new SuccessDataResult<List<Product>>(products);
        }

        public async Task<IDataResult<List<Product>>> GetAllWithCategoryAsync()
        {
            var products = await _productDal.GetAllWithCategoty();
            return new SuccessDataResult<List<Product>>(products);

        }

        public async Task<IDataResult<List<Product>>> GetByCategoryIdAsync(int id)
        {
            var products = await _productDal.GetAllAsync(x => x.CategoryId == id);
            return new SuccessDataResult<List<Product>>(products);
        }

        public async Task<IDataResult<List<Product>>> GetProductsWithCategoryByCategoryIdAsync(int id)
        {
            var products = await _productDal.GetAllWithCategoty(x => x.CategoryId == id);
            return new SuccessDataResult<List<Product>>(products);
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int id)
        {
            var product = await _productDal.GetAsync(x => x.ProductId == id);
            return new SuccessDataResult<Product>(product);
        }

        public async Task<IResult> UpdateAsync(Product product)
        {
            await _productDal.UpdateAsync(product);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Product>>> GetProductsStatusTrueAsync()
        {
            var products = await _productDal.GetAllAsync(x => x.Status == true);
            return new SuccessDataResult<List<Product>>(products);
        }

        public async Task<IDataResult<List<Product>>> GetProductsStatusTrueByCategoryIdAsync(int id)
        {
            var productList = await _productDal.GetAllAsync(x => x.CategoryId == id);
            var products = productList.Where(x => x.Status == true).ToList();
            return new SuccessDataResult<List<Product>>(products);
        }
    }
}
