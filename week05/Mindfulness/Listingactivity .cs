using System;
using System.Collections.Generic;
 
public class ListingActivity : Activity
{
    private List<string> _prompts;
    private static Random _random = new Random();
 
    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
 
    public void Run()
    {
        DisplayStartingMessage();
 
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        int promptIndex = _random.Next(_prompts.Count);
        Console.WriteLine("--- " + _prompts[promptIndex] + " ---");
 
        ShowCountDown(5);
 
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
 
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }
 
        Console.WriteLine();
        Console.WriteLine("You listed " + items.Count + " items!");
 
        DisplayEndingMessage();
    }
}