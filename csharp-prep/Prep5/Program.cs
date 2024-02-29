using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int number = PromptUserNumber();

        int squared = SquareNumber(number);
        DisplayResult(userName, squared);

    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name =  Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int FavNumber = int.Parse(Console.ReadLine());
            return FavNumber;
        }
        static int SquareNumber(int FavoriteNumber)
        {
            int squaredNumber = FavoriteNumber * FavoriteNumber;
            return squaredNumber;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
        



    
}