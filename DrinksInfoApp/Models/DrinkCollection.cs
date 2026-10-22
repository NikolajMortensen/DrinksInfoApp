using System.Text.Json.Serialization;

namespace DrinksInfoApp.Models;

public class DrinkCollection
{
    [JsonPropertyName("drinks")]
    public List<DrinkDto> Drinks { get; set; }
}