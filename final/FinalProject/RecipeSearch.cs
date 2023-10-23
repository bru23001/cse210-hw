/* It will sort, filter, and search for recipes according to the ingredients stored, type of meal, and season of the year. */

class RecipeSearch {
    public List<Recipe> SortRecipes(List<Recipe> recipes, string sortBy) {
        switch (sortBy) {
            case "Name":
                recipes.Sort();
                break;
            case "Ingredients":
                // sort by ingredients logic
                break;
            case "Event":
                // sort by event logic
                break;
            default:
                break;
        }
        return recipes;
    }

    public List<Recipe> FilterRecipes(List<Recipe> recipes, string filterBy) {
        switch (filterBy) {
            case "Vegetarian":
                recipes = recipes.FindAll(recipe => recipe.Ingredients.Contains("vegetarian"));
                break;
            case "Non-Vegetarian":
                recipes = recipes.FindAll(recipe => !recipe.Ingredients.Contains("vegetarian"));
                break;
            default:
                break;
        }
        return recipes;
    }

    public List<Recipe> SearchRecipes(List<Recipe> recipes, string searchBy) {
        return recipes.FindAll(recipe => recipe.Name.Contains(searchBy));
    }
}
