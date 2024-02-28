using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputNumber = -1;

        while (inputNumber != 0)
        {
            
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            inputNumber = int.Parse(response);
            if (inputNumber != 0)
            {
            numbers.Add(inputNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}.");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
       Console.WriteLine($"The largest number is {largest}.");
    } 

}