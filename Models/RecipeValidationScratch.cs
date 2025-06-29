using System.Collections.Generic;
using System.Linq;

namespace WellnessWitch.Models
{
    public static class RecipeValidationScratch
    {
        // Validates a recipe based on the new rules:
        // - Exactly 2 base ingredients (fruit, vegetable, or liquid, not both of the same type)
        // - Exactly 2 topping ingredients (herb, powder, seed, spice, or flower, not both of the same type)
        public static bool IsValidRecipe(List<Ingredient> ingredients)
        {
            if (ingredients == null || ingredients.Count != 4)
                return false;

            var baseTypes = new[] { "fruit", "vegetable", "liquid" };
            var toppingTypes = new[] { "herb", "powder", "seed", "spice", "flower" };

            var bases = ingredients.Where(i => baseTypes.Contains(i.Type)).ToList();
            var toppings = ingredients.Where(i => toppingTypes.Contains(i.Type)).ToList();

            if (bases.Count != 2 || toppings.Count != 2)
                return false;

            if (bases[0].Type == bases[1].Type)
                return false;
            if (toppings[0].Type == toppings[1].Type)
                return false;

            return true;
        }
    }
} 