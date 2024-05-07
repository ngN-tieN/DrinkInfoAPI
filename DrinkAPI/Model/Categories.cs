

using DrinkAPI.Models;
using System.Text.Json.Serialization;

namespace DrinkAPI.Model
{
    internal class CategoriesDTO
    {
        [property: JsonPropertyName("drinks")]
        public List<CategoryDTO> Categories { get; set; }
    }
}
