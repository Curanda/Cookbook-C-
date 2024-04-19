using CookBook;

public class Program
{
    // program w konsoli. po odpaleniu program sie wita.
    // podaje ilość dostepnych przepisow. metoda printRecipes()
    // pyta czy uzytkownik chce dodac przepis czy odczytac przepis. metoda addOrReadRecipe()
    // jesli odczytac przepis to pyta o numer przepisu. metoda readRecipe()
    // wypisuje przepis i pyta czy uzytkownik chce edytowac. metoda printRecipe()
    // jesli tak to pyta o numer kroku | skladnika ktory chce edytowac. metoda editRecipe()
    // wypisuje krok i pyta o nowy krok. 
    // pyta czy zapisac zmiany. medota saveChanges()
    // jesli tak to zapisuje zmiany. 
    // wypisuje edytowany przepis. metoda printRecipe()
    
    // jesli uzytkownik chce dodac przepis to pyta o nazwe przepisu i czy zapisac nazwe.
    // pyta o ilosc skladnikow i czy zapisac ilosc skladnikow.
    // pyta o skladniki i czy zapisac skladniki.
    // pyta o ilosc krokow i czy zapisac ilosc krokow.
    // pyta kolejno o kazdy krok i czy zapisac krok.
    // pyta zapisz | edytuj | wyjdz do listy przepisow bez zapisywania.
    // jesli zapisz to zapisuje przepis i wypisuje na ekranie.
    
    /*
     * przepis
     * key: nazwa przepisu
     * value: przepis
     *
     * key: przepis
     * value: list skladniki, list kroki
     * 
     */
     
  // moze zamiast hashtable lepiej bedzie uzyc wielowymiarowej listy. Przepisy[nazwyPrzepisow[skladniki[], kroki[]]]


    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to CookBook!");
        Console.WriteLine("Available recipes: " + recipes.Count);
        recipes.Add("pierogi", new Recipe("pierogi"));
        
    } 
}