using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your guess?");
        int number = int.Parse(Console.ReadLine());
        if (number == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

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