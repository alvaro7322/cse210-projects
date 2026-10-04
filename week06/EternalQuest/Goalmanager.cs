using System;
using System.Collections.Generic;
using System.IO;
 
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
 
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
 
    public void Start()
    {
        bool keepGoing = true;
 
        while (keepGoing)
        {
            Console.WriteLine();
            Console.WriteLine("You have " + _score + " points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
 
            string choice = Console.ReadLine();
 
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                keepGoing = false;
            }
        }
    }
 
    private void ListGoalDetails()
    {
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetDetailsString());
        }
    }
 
    private void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();
 
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
 
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
 
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
 
        if (typeChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (typeChoice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (typeChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetAmount = int.Parse(Console.ReadLine());
 
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
 
            _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonus));
        }
    }
 
    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
 
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score = _score + pointsEarned;
            Console.WriteLine("You earned " + pointsEarned + " points!");
        }
    }
 
    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
 
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
 
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
 
        Console.WriteLine("Goals saved successfully!");
    }
 
    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
 
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
 
        string[] lines = File.ReadAllLines(fileName);
 
        _goals.Clear();
        _score = int.Parse(lines[0]);
 
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] data = parts[1].Split(",");
 
            if (goalType == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);
 
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
 
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int targetAmount = int.Parse(data[3]);
                int bonus = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);
 
                ChecklistGoal goal = new ChecklistGoal(name, description, points, targetAmount, bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
 
        Console.WriteLine("Goals loaded successfully!");
    }
}