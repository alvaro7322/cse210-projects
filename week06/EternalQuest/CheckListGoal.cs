using System;
 
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;
 
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonus = bonus;
    }
 
    public override int RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        int pointsEarned = GetPoints();
 
        if (_amountCompleted == _targetAmount)
        {
            pointsEarned = pointsEarned + _bonus;
        }
 
        return pointsEarned;
    }
 
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }
 
    public override string GetDetailsString()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "[X] ";
        }
        else
        {
            checkbox = "[ ] ";
        }
 
        return checkbox + GetName() + " Completed " + _amountCompleted + "/" + _targetAmount + " times";
    }
 
    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:" + GetName() + "," + GetDescription() + "," + GetPoints() + "," + _targetAmount + "," + _bonus + "," + _amountCompleted;
    }
}