/*Fraction

_top : int
_bottom : int

Fraction()
Fraction(wholeNumber : int)
Fraction(top : int, bottom : int)

GetTop() : int
SetTop(top : int)
GetBottom() : int
SetBottom(bottom : int)

GetFractionString() : string
GetDecimalValue() : double*/





using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor that initializes the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that initializes the fraction to wholeNumber/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that initializes the fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
