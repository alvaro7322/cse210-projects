using System;
using System.Collections.Generic;
using System.Threading;
 
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
 
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
 
    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Starting the " + _name + " Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
 
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
 
    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
 
        Console.WriteLine();
        Console.WriteLine("You have completed the " + _name + " Activity for " + _duration + " seconds.");
        ShowSpinner(3);
    }
 
    protected void ShowSpinner(int seconds)
    {
        List<string> animationFrames = new List<string>();
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");
 
        int frameIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
 
        while (DateTime.Now < endTime)
        {
            Console.Write(animationFrames[frameIndex]);
            Thread.Sleep(250);
            Console.Write("\b \b");
 
            frameIndex = frameIndex + 1;
            if (frameIndex >= animationFrames.Count)
            {
                frameIndex = 0;
            }
        }
    }
 
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
 
    protected int GetDuration()
    {
        return _duration;
    }
}