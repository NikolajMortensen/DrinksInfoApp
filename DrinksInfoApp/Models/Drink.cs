namespace DrinksInfoApp.Models;

public class Drink
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public List<String> Ingredients { get; set; }
}