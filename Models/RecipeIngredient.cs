using System;

namespace WellnessWitch.Models
{
    public class RecipeIngredient
    {
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public int RecipeId { get; set; }
    }
} 