using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] drinks = { "Fanta", "Coca-Cola", "Sprite", "juice" };
            string[] foods = { "chiken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] movies = { "Predator", "Titanic", "Fast & Furious", "Peppa Pig" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you wil have some {randomFood} with {randomDrink} and watch { randomMovie}.");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;

        }

    }
}
