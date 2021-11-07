using System;

namespace FridayNigthRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomFilm();

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chiken wings", "pizza", "sushi", "popcorn", "salad" };

            
            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Fanta", "Coca-Cola", "Sprite", "juice" };
            
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomFilm()
        {
            string[] films = { "Predator", "Titanic", "Fast & Furious", "Peppa Pig" };
           
            Console.WriteLine($"Computer picked: {films[GenerateRandomIndex(films)]}");
        }
    }
}
