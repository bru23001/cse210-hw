/*
This class will rotate the recipes around the year, it will create a list of meal according
with the recipes stored, the ingredients stored, and the season of the year. Properties: 
list of meals. Methods: Plan().
*/

class MealPlan 
{
    public List<string> Meals { get; set; }
    
    public void Plan()
    {
        // meal plan logic
        Meals = new List<string>();
        for (int i = 0; i < 7; i++) // For each day of the week
        {
            Meals.Add(Meal());
        }
    }

    public string Meal()
    {
        // Define what the Meal method does here
        // For example, return a random meal:
        string[] possibleMeals = { "Breakfast", "Lunch", "Dinner" };
        Random rand = new Random();
        int index = rand.Next(possibleMeals.Length);
        return possibleMeals[index];
    }
}

