using DrinksInfoApp.Models;
using DrinksInfoApp.Serices;
using Spectre.Console;

namespace DrinksInfoApp;

public class UserInput
{
    private readonly DrinksApiClient _apiClient;
    private readonly DrinkService _drinkService;

    public UserInput(DrinksApiClient apiClient)
    {
        _apiClient = apiClient;
        _drinkService = new DrinkService();
    }

    public async Task StartMenu()
    {
        while (true)
        {
            Console.Clear();
            
            // Category Menu
            List<Category> categories = await _apiClient.GetCategoriesJson();
            List<string> categoryNames = categories.Select(c => c.Name).ToList();
            categoryNames.Add("Exit program");

            string selectedCategory = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose [green]category[/] (use arrow keys):")
                    .PageSize(10)
                    .AddChoices(categoryNames)
            );

            if (selectedCategory == "Exit program") break;

            
            // Drinks menu
            List<DrinkDto> drinks = await _apiClient.GetDrinksByCategory(selectedCategory);
            List<string> drinkNames = drinks.Select(d => d.Name).ToList();
            drinkNames.Add("Return");
            
            string selectedDrinkName = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"Choose [green]drink[/] in category {selectedCategory} (use arrow keys):")
                    .PageSize(10)
                    .AddChoices(drinkNames)
            );

            if (selectedDrinkName == "Return") continue;
            
            // Drink details menu
            DrinkDto selectedDrink = drinks.First(d => d.Name == selectedDrinkName);
            string drinkId = selectedDrink.Id;

            DrinkDto rawDrinkDetails = await _apiClient.GetDrinkDetailsById(drinkId);
            Drink drink = _drinkService.ToDrink(rawDrinkDetails);

            Console.WriteLine($"\n--- {drink.Name} ---");
            foreach (string ingredient in drink.Ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }

            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
        }
    }
}