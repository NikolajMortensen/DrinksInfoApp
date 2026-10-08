using System.Text.Json.Serialization;

namespace DrinksInfoApp.Models;

public class DrinkDto
{
    [JsonPropertyName("idDrink")]
    public string Id { get; set; }
    
    [JsonPropertyName("strDrink")]
    public string Name { get; set; }
    
    [JsonPropertyName("strCategory")]
    public string Category { get; set; }
    
    [JsonPropertyName("strIngredient1")]
    public string Ingredient1 { get; set;}
    
    [JsonPropertyName("strIngredient2")]
    public string Ingredient2 { get; set;}

    [JsonPropertyName("strIngredient3")]
    public string Ingredient3 { get; set;}

    [JsonPropertyName("strIngredient4")]
    public string Ingredient4 { get; set;}

    [JsonPropertyName("strIngredient5")]
    public string Ingredient5 { get; set;}

    [JsonPropertyName("strIngredient6")]
    public string Ingredient6 { get; set;}

    [JsonPropertyName("strIngredient7")]
    public string Ingredient7 { get; set;}

    [JsonPropertyName("strIngredient8")]
    public string Ingredient8 { get; set;}

    [JsonPropertyName("strIngredient9")]
    public string Ingredient9 { get; set;}

    [JsonPropertyName("strIngredient10")]
    public string Ingredient10 { get; set;}

    [JsonPropertyName("strIngredient11")]
    public string Ingredient11 { get; set;}

    [JsonPropertyName("strIngredient12")]
    public string Ingredient12 { get; set;}

    [JsonPropertyName("strIngredient13")]
    public string Ingredient13 { get; set;}

    [JsonPropertyName("strIngredient14")]
    public string Ingredient14 { get; set;}

    [JsonPropertyName("strIngredient15")]
    public string Ingredient15 { get; set;}

    
}