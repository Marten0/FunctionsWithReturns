using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "chicken wings", "burger", "french fries", "salad", "nuggets" };
            string[] drinks = { "coca cola", "fanta", "sprite", "still water" };
            string[] movies = { "Titanic", "Harry Potter", "Cars" };

            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovie = PickRandomFromArray(movies);

            Console.WriteLine($"Computer picked {randomSnack} and {randomDrink} and for a {randomMovie} night.");

        }
        
        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement;
        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomIndex]}");
        }



    }
}
