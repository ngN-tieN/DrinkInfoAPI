using System.Net.Http.Headers;
using System.Text.Json;
using DrinkAPI.Model;
using DrinkAPI.Models;
namespace DrinkAPI.Services

{
    internal class FetchCategoryAPI
    {
        public async Task<List<CategoryDTO>> FetchCategoriesAsync()
        {
            using (HttpClient client = new())
            { 
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var categories = await ProcessCategoriesAsync(client, "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");
                return categories;
            }
        }
        public async Task<List<CategoryDTO>> ProcessCategoriesAsync(HttpClient client, string api)
        {
            var stream = await client.GetStreamAsync(api);
            var categories =
                await JsonSerializer.DeserializeAsync<CategoriesDTO>(stream);
            return categories.Categories;
            
        }


    }
}
