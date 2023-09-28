using System;

//1. Create a class to hold fraction.
//2. The class should be in its own file.
public class Fraction
{
    //ATRIBUTES===============================================================
    //3. The class should have two attributes for the top and bottom numbers.
    //4. Make sure the attributes are private.
    private int _top;
    private int _bottom;

    //CONSTRUCTORS=============================================================
    //5. Constructor that has no parameters that initializes the number to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //6. Constructor that has one parameter for the top and that initializes the denominator to 1. 
    // So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //7. Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //8.Create getters and setters for both the top and the bottom values.
    public int GetTopNumber()
    {
        return _top;
    }
    public void SetTopNumber(int top)
    {
        _top = top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }
    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }
    // 9.Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    //10.Create a method called GetDecimalValue that returns a double that is the result of 
    //dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        double decimalValue = (double) _top / (double)_bottom;
        return decimalValue;
    }





}