# Recipe

# RecipeApp

## Overview
RecipeApp is a simple console application that allows you to manage and categorize recipes. Users can add new recipes, retrieve all recipes, and filter recipes based on their category.

## Features
- Add new recipes with a name and category.
- Retrieve all added recipes.
- Filter recipes by category.

## Prerequisites
- .NET SDK 5.0 or later

## Usage
The `RecipeApp` application provides a `RecipeManager` class to manage recipes and a `Recipe` class to represent a recipe with a name and category. Below is an example of how to use the application:

```csharp
var recipeManager = new RecipeManager();

// Add some recipes
recipeManager.AddRecipe(new Recipe("Scrambled Eggs", "Breakfast"));
recipeManager.AddRecipe(new Recipe("Chicken Curry", "Dinner"));
recipeManager.AddRecipe(new Recipe("Chocolate Cake", "Cakes"));

// Get all recipes
var allRecipes = recipeManager.GetAllRecipes();
Console.WriteLine("All Recipes:");
foreach (var recipe in allRecipes)
{
    Console.WriteLine($"- {recipe.Name} ({recipe.Category})");
}
Console.WriteLine();

// Get recipes by category
var category = "Cakes";
var recipesByCategory = recipeManager.GetRecipesByCategory(category);
Console.WriteLine($"Recipes in the '{category}' category:");
foreach (var recipe in recipesByCategory)
{
    Console.WriteLine($"- {recipe.Name}");
}

