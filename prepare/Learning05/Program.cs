/*
1. n your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
2. Add a square, rectangle, and circle to this list.
3. Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string figure = "";
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square(5, "red");
        Rectangle shape2 = new Rectangle(4,6,"blue");
        Circle shape3 = new Circle(3, "green");
        

        foreach (Shape shape in shapes)
        {
            string color= shape.GetColor();

            if (color == "red")
            {
                figure = "square";
            }
            else if (color == "blue")
            {
                figure = "rectangle";
            }
            else if (color == "green")
            {
                figure = "circle";
            }

            Console.WriteLine($"This {color} {figure} has an area of {shape.GetArea()} inches");
        }
    }
}
