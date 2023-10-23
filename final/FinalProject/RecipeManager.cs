/*
This class represents a recipe box. This class will have a property that is a collection of 
recipes. Other properties are name of recipe, ingredients, steps, comments, Event, Frequency, 
and NextTime. Methods: 1. RecipeDisplay(), 2. EditRecipe(), 3. RateRecipe(), 
4. AdjustRecipe(): it will modify on screen the quantity of ingredients according to the number 
of people eating that meal.
*/

class RecipeManager 
{
    public List<Recipe> Recipes { get; set; }
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Steps { get; set; }
    public List<string> Comments { get; set; }
    public string Event { get; set; }
    public string Frequency { get; set; }
    public DateTime NextTime { get; set; }
    
    public void RecipeDisplay()
    {
        Console.WriteLine($"Name: {Name}\nIngredients: {string.Join(", ", Ingredients)}\nSteps: {string.Join(", ", Steps)}\nComments: {string.Join(", ", Comments)}\nEvent: {Event}\nFrequency: {Frequency}\nNext Time: {NextTime}");
    }
    
    public void EditRecipe(string name, List<string> ingredients, List<string> steps, List<string> comments, string @event, string frequency, DateTime nextTime)
    {
        Name = name;
        Ingredients = ingredients;
        Steps = steps;
        Comments = comments;
        Event = @event;
        Frequency = frequency;
        NextTime = nextTime;
    }
    
    public void RateRecipe(int rating)
{
    if (rating < 1 || rating > 5)
    {
        Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
        return;
    }

    // Save the rating to the recipe object or to a database
    Console.WriteLine($"Recipe rated {rating} out of 5.");
}

    
    public void AdjustRecipe(int numberOfPeople)
    {
        // adjust recipe logic
    }
}
