using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinkAPI.Model
{
    internal class DrinkDTO
    {
        [property: JsonPropertyName("strDrink")]
        public int Drink{ get; set; }

        [property:JsonPropertyName("strDrinkThumb")] 
        public Uri DrinkThumb { get; set; }

        [property:JsonPropertyName("idDrink")]
        public int Id { get; set;}
    }
}
