namespace DrinksInfoApp.Models;

public class DrinkService
{
    public Drink ToDrink(DrinkDto dto)
    {
        List<string> rawIngredients = new()
        {
            dto.Ingredient1,
            dto.Ingredient2,
            dto.Ingredient3,
            dto.Ingredient4,
            dto.Ingredient5,
            dto.Ingredient6,
            dto.Ingredient7,
            dto.Ingredient8,
            dto.Ingredient9,
            dto.Ingredient10,
            dto.Ingredient11,
            dto.Ingredient12,
            dto.Ingredient13,
            dto.Ingredient14,
            dto.Ingredient15
        };

        List<string> actualIngredients = rawIngredients
                .Where(ingredient => !string.IsNullOrWhiteSpace(ingredient))
                .ToList();
        
        Drink drink = new();
        drink.Id = dto.Id;
        drink.Category = dto.Category;
        drink.Name = dto.Name;
        drink.Ingredients = actualIngredients;

        return drink;
    }
}