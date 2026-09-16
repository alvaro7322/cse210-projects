using System;
using System.Globalization;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int top)
    {
        this.top = top;
        this.bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public int GetTop()
    {
        return top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    public string GetFractionString()
    {
        return top + "/" + bottom;
    }

    public string GetDecimalValue()
    {
        double result = (double)top / bottom;
        return result.ToString(CultureInfo.InvariantCulture);
    }
}