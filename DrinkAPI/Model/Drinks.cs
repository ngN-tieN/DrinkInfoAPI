using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrinkAPI.Model
{
    internal class DrinksInfo
    {
        [property:JsonPropertyName("drinks")]
        public List<DrinkDTO> Drinks {  get; set; }
    }
}
