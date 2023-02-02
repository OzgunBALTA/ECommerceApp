using MvcWebUI.ApiServices.Abstract;
using MvcWebUI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MvcWebUI.ApiServices.Concrete
{
    public class ProductApiManager : IProductApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration Configuration { get; }

        public ProductApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            Configuration = configuration;
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri($"{Configuration["BaseUrl"]}Products/");       
        }

        public async Task AddAsync(ProductModel productModel)
        {
            var jsonProduct = JsonConvert.SerializeObject(productModel);
            StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("add", content);
        }

        public async Task ChangeStatusAsync(int id)
        {
            var jsonProduct = JsonConvert.SerializeObject(id);
            StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync($"changestatus/{id}", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"delete/{id}");
        }

        public async Task<List<ProductModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getall");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<ProductModel>> GetAllWithCategoryAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getallwithcategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<ProductModel> GetAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"getbyid/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ProductModel>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<ProductModel>> GetProductsByCategoryIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"getproductsbycategoryid/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<ProductModel>> GetProductsStatusTrue()
        {
            var responseMessage = await _httpClient.GetAsync("getproductsstatustrue");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<ProductModel>> GetProductsStatusTrueByCategoryIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"getproductsstatustruebycategoryid/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<ProductModel>> GetProductsWithCategoryByCategoryIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"getproductsbycategoryid/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProductModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task UpdateAsync(ProductModel productModel)
        {
            var jsonCategory = JsonConvert.SerializeObject(productModel);
            StringContent content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("update", content);
        }
    }
}
