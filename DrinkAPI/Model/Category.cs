
using System.Text.Json.Serialization;

namespace DrinkAPI.Models
{ 
    internal class CategoryDTO
    {
        [property: JsonPropertyName("strCategory")]
        public string Name { get; set; } 
    }
}
