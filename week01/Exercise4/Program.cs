using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int count = numbers.Count;
        int suma = 0;
        foreach (int digit in numbers)
        {
            suma += digit;
        }
        int bigNumber = numbers[0];
        foreach (int digit in numbers)
        {
            if (digit > bigNumber)
            {
                bigNumber = digit;
            }
        }
        int average = suma / count;
        Console.WriteLine($"The sum is: {suma}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {bigNumber}");
    }
}