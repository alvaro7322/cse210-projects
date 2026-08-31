using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What's your score?");
        int score = int.Parse(Console.ReadLine());
        if (score >= 90)
        {
            Console.WriteLine("You got an A");
            Console.WriteLine("Good job, you pass this course");
        }
        else if (score >= 80)
        {
            Console.WriteLine("You got an B");
            Console.WriteLine("Good job, you pass this course");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got an C");
            Console.WriteLine("Good job, you pass this course");
        }
        else if (score >= 60)
        {
            Console.WriteLine("You got an D");
            Console.WriteLine("More experience for the next time, I guess");
        }
        else if (score < 60)
        {
            Console.WriteLine("You got an F");
            Console.WriteLine("More experience for the next time, I guess");
        }
    }
    
}