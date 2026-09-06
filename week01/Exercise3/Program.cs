using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        Console.WriteLine("What is your guess?");
        int number = int.Parse(Console.ReadLine());

        while (magicNumber != number)
        {
            if (number > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("What is your guess?");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
    }
}