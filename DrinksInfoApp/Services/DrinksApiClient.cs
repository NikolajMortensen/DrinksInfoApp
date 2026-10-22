using System.Text.Json;
using DrinksInfoApp.Models;

namespace DrinksInfoApp.Serices;

public class DrinksApiClient
{
    private readonly HttpClient _httpClient;
    
    public DrinksApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Category>> GetCategoriesJson()
    {
        string url = "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list";

        var json = await _httpClient.GetStringAsync(url);

        Categories response = JsonSerializer.Deserialize<Categories>(json);

        return response.CategoriesList;
    }

    public async Task<List<DrinkDto>> GetDrinksByCategory(string categoryName)
    {
        string url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?c={categoryName}";

        var json = await _httpClient.GetStringAsync(url);

        DrinkCollection response = JsonSerializer.Deserialize<DrinkCollection>(json);

        return response.Drinks;
    }

    public async Task<DrinkDto> GetDrinkDetailsById(string drinkId)
    {
        string url = $"https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i={drinkId}";

        var json = await _httpClient.GetStringAsync(url);

        DrinkCollection drinkReponse = JsonSerializer.Deserialize<DrinkCollection>(json);
        
        return drinkReponse.Drinks[0];
    }
    
    
}