using MvcWebUI.ApiServices.Abstract;
using MvcWebUI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MvcWebUI.ApiServices.Concrete
{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration Configuration { get; }
        public CategoryApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            Configuration = configuration;
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri($"{Configuration["BaseUrl"]}Categories/");
        }

        public async Task AddAsync(CategoryModel categoryModel)
        {
            var jsonCategory = JsonConvert.SerializeObject(categoryModel);
            StringContent content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("add", content);
        }

        public async Task ChangeStatusAsync(int id)
        {
            var jsonCategory = JsonConvert.SerializeObject(id);
            StringContent content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync($"changestatus/{id}", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"delete/{id}");
        }

        public async Task<List<CategoryModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getall");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<CategoryModel> GetAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"getbyid/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CategoryModel>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<CategoryModel>> GetCategoriesStatusTrueAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getcategoriesstatustrue");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task UpdateAsync(CategoryModel categoryModel)
        {
            var jsonCategory = JsonConvert.SerializeObject(categoryModel);
            StringContent content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"update", content);
        }
    }
}
