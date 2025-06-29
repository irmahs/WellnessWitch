using System;

namespace WellnessWitch.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // powder, herb, spice, fruit, vegetable, liquid, seed
    }
} 