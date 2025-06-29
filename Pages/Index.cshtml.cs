using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WellnessWitch.Models;

namespace WellnessWitch.Pages
{
    public class IndexModel : PageModel
    {
        public Dictionary<string, List<Ingredient>> BaseIngredientsByType { get; set; }
        public Dictionary<string, List<Ingredient>> ToppingIngredientsByType { get; set; }
        public List<dynamic> Recipes { get; set; }

        public void OnGet()
        {
            // Load base ingredients
            var baseJson = System.IO.File.ReadAllText("Data/base_ingredients.json");
            var baseIngredients = JsonSerializer.Deserialize<List<Ingredient>>(baseJson);
            BaseIngredientsByType = baseIngredients
                .Where(i => i.Type != "herb")
                .GroupBy(i => i.Type)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Load topping ingredients
            var toppingJson = System.IO.File.ReadAllText("Data/topping_ingredients.json");
            var toppingIngredients = JsonSerializer.Deserialize<List<Ingredient>>(toppingJson);
            ToppingIngredientsByType = toppingIngredients
                .GroupBy(i => i.Type)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Load recipes (dynamic for now, as structure is custom)
            var recipesJson = System.IO.File.ReadAllText("Data/recipes.json");
            Recipes = JsonSerializer.Deserialize<List<dynamic>>(recipesJson);
        }
    }
}
