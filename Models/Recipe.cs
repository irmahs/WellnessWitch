using System.Collections.Generic;

namespace WellnessWitch.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
    }
} 