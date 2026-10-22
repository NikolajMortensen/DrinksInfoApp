using System.Text.Json.Serialization;

namespace DrinksInfoApp.Models;

public class Category
{
    [JsonPropertyName("strCategory")]
    public string Name { get; set; }
}

public class Categories
{
    [JsonPropertyName("drinks")]
    public List<Category> CategoriesList { get; set; }
}