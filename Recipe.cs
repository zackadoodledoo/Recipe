using System;
using System.Collections.Generic;
using System.Linq;
  
namespace RecipeApp
{
    // <summary>
    // Represents a recipe with a name and a category.
    // </summary>
    public class Recipe
    {
        public string Name { get; set; }
        public string Category { get; set; }
 
        // <summary>
        // Constructs a new recipe with the specified name and category.
        //
        // Parameters:
        // - name: The name of the recipe.
        // - category: The category of the recipe.
        // </summary>
        public Recipe(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
 
    // <summary>
    // Represents a recipe manager that allows adding, retrieving, and categorizing recipes.
    // </summary>
    public class RecipeManager
    {
        private List<Recipe> recipes;
 
        // <summary>
        // Constructs a new recipe manager.
        // </summary>
        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }
 
        // <summary>
        // Adds a recipe to the recipe manager.
        //
        // Parameters:
        // - recipe: The recipe to add.
        // </summary>
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
 
        // <summary>
        // Retrieves all recipes in the recipe manager.
        //
        // Returns:
        // - A list of all recipes.
        // </summary>
        public List<Recipe> GetAllRecipes()
        {
            return recipes;
        }
 
        // <summary>
        // Retrieves recipes in the specified category.
        //
        // Parameters:
        // - category: The category of the recipes to retrieve.
        //
        // Returns:
        // - A list of recipes in the specified category.
        // </summary>
        public List<Recipe> GetRecipesByCategory(string category)
        {
            return recipes.Where(r => r.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
 
    public class Program
    {
        public static void Main()
        {
            // Create a recipe manager.
            var recipeManager = new RecipeManager();
 
            // Add some recipes.
            recipeManager.AddRecipe(new Recipe("Scrambled Eggs", "Breakfast"));
            recipeManager.AddRecipe(new Recipe("Chicken Curry", "Dinner"));
            recipeManager.AddRecipe(new Recipe("Chocolate Cake", "Cakes"));
            recipeManager.AddRecipe(new Recipe("Caesar Salad", "Salads"));
            recipeManager.AddRecipe(new Recipe("Garlic Bread", "Side Dishes"));
            recipeManager.AddRecipe(new Recipe("Grilled Salmon", "Fish"));
 
            // Get all recipes.
            var allRecipes = recipeManager.GetAllRecipes();
            Console.WriteLine("All Recipes:");
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"- {recipe.Name} ({recipe.Category})");
            }
            Console.WriteLine();
 
            // Get recipes by category.
            var category = "Cakes";
            var recipesByCategory = recipeManager.GetRecipesByCategory(category);
            Console.WriteLine($"Recipes in the '{category}' category:");
            foreach (var recipe in recipesByCategory)
            {
                Console.WriteLine($"- {recipe.Name}");
            }
        }
    }
}