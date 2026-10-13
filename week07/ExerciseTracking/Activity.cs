using System;
using System.Globalization;
 
public abstract class Activity
{
    private DateTime _date;
    private double _minutes;
 
    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
 
    protected double GetMinutes()
    {
        return _minutes;
    }
 
    public abstract double GetDistance(); // miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile
 
    public string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string name = GetType().Name;
        return string.Format(CultureInfo.InvariantCulture,
            "{0} {1} ({2} min): Distance {3:F1} miles, Speed: {4:F1} mph, Pace: {5:F1} min per mile",
            date, name, _minutes, GetDistance(), GetSpeed(), GetPace());
    }
}