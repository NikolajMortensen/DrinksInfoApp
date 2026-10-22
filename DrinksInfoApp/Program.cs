using DrinksInfoApp;
using DrinksInfoApp.Serices;

using HttpClient httpClient = new();
DrinksApiClient drinksApiClient = new(httpClient);

UserInput menu = new UserInput(drinksApiClient);

await menu.StartMenu();