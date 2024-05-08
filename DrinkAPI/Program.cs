using DrinkAPI.Services;
using DrinkAPI.Utils;

namespace DrinkAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var list = await new FetchDrinksByCategoryAPI().FetchDrinksByCategoryAsync("Cocktail");
            TableExt.PrintDrinksInfoTable(list);
        }
    }
}
