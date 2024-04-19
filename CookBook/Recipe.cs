namespace CookBook;

public class Recipe
{
    private int? id = null;
    private String name = "";
    private String ingredient = "";
    private String step = "";
    private List<String> ingredients = new List<string>();
    private List<String> steps = new List<string>();
    
    public Recipe(String name)
    {
        this.name = name;
    }
    
    public void AddIngredient(String ingredient)
    {
        ingredients.Add(ingredient);
        Console.WriteLine("Added ingredient: " + ingredient);
    }
    
    public void AddStep(String step)
    {
        steps.Add(step);
        Console.WriteLine("Added step: " + step);
    }
    
    public void PrintRecipe()
    {
        Console.WriteLine("Recipe: " + name);
        Console.WriteLine("Ingredients:");
        foreach (String ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
        Console.WriteLine("Steps:");
        foreach (String step in steps)
        {
            Console.WriteLine(step);
        }
    }
    
}