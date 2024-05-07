


using System.Text.Json.Serialization;

namespace DrinkAPI.Model
{
    internal class DrinksInfo
    {
        [property:JsonPropertyName("drinks")]
        public List<DrinkDTO> Drinks { get; set; }
    }
}
