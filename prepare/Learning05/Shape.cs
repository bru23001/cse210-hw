/*
1. Add the color member variable and a getter and setter for it.
2. Create a constructor that accepts the color and set its.
3. Create a virtual method for GetArea().

*/

public class Shape
{
    protected string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}
