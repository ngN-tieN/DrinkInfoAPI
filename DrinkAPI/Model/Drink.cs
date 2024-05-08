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
        [property: JsonPropertyName("idDrink")]
        public string Id { get; set; }

        [property: JsonPropertyName("strDrink")]
        public string Drink{ get; set; }

    }
}
