/*
1. Make sure this class inherits from the base class.
2. Create a constructor that accepts the color and the side, and then call the base constructor with the color.
3. Create the _side attribute as a private member variable.
4. Override the GetArea() method from the base class and fill in the body of this function to return the area.

*/

public class Rectangle : Shape
{
    private double _length, _width;

    public Rectangle(double length, double width, string color):base(color)
    {
        _length = length;
        _width = width;
       
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}

