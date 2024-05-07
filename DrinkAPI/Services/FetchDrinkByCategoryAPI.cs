using DrinkAPI.Model;
using System.Net.Http.Headers;
using System.Text.Json;

namespace DrinkAPI.Services
{
    internal class FetchDrinksByCategoryAPI
    {
        public async Task<List<DrinkDTO>> FetchDrinksByCategory(string categoryName)
        {
            using(HttpClient client = new()) 
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string uri = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?c={categoryName}";
                var drinkList = await ProcessDrinksByCategoryAsync(client, uri);
                return drinkList;
            }
        }

        public async Task<List<DrinkDTO>> ProcessDrinksByCategoryAsync(HttpClient client, string api) 
        {
            var stream = await client.GetStreamAsync(api);
            var drinks =
                await JsonSerializer.DeserializeAsync<DrinksInfo>(stream);
            return drinks.Drinks;
        }
    }
}
