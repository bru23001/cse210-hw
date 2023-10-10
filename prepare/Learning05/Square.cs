/*
1. Make sure this class inherits from the base class.
2. Create a constructor that accepts the color and the side, and then call the base constructor with the color.
3. Create the _side attribute as a private member variable.
4. Override the GetArea() method from the base class and fill in the body of this function to return the area.

*/

public class Square : Shape
{
    private double _side;

    public Square(double side, string color):base(color)
    {
        _side = side;
        
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
