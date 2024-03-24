namespace RandomNumberDemo
{
    

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(5, 11));//5 is the minimum and 11 will be the maximum number
        }
        Console.ReadLine();
    }

    private static void SimpleMethod(Random random)
    {
        {
            Console.WriteLine(random.Next());//simple method to just call the random method
        }
    }

    List<PersonModel> people = new <PersonModel>
}
}