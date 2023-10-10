/*
1. Make sure this class inherits from the base class.
2. Create a constructor that accepts the color and the side, and then call the base constructor with the color.
3. Create the _side attribute as a private member variable.
4. Override the GetArea() method from the base class and fill in the body of this function to return the area.

*/

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}

