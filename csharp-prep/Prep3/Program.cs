using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.Write("What is the magic number? ");
        //string guess = Console.ReadLine();
        //int guess1 = int.Parse(guess);

        //Console.Write("What is your guess? ");
        //string answer = Console.ReadLine();
        //int answer1 = int.Parse(answer);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        
        int myGuess = -1;

        while (myGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            
            myGuess = int.Parse(Console.ReadLine());

            if (magicNumber > myGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < myGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        
        }
    }
}