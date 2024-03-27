using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)

    {
        
        for (int i = 1; i <= 100; i++ )
        {
            if (i%3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (i % 5 == 0)
            {
            Console.WriteLine("Buzz");
            }
            if (i % 3==0 && i % 5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
        int[] firstNum = new int[] {};
        List<string> arrayNum = new List<string>();
        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                arrayNum.Add("Fizz");
            }
        }
    }
}