using System;
using System.Xml.Schema;

class Program
{
    private static void Main(string[] args)
    {
        //1. Create an instance for 1/1 (using the first constructor), 
        // for 6/1 (using the second constructor), for 6/7 (using the third constructor).
        
        Fraction f1 = new Fraction(13,5);
        Fraction f2 = new Fraction(6,18);
        Fraction f3 = new Fraction(2335, 985);

        //2. verify that you can call all of these methods and get the correct values, using 
        //setters to change the values and then getters to retrieve these new values and then 
        //display them to the console.

        Console.WriteLine(f1.GetTopNumber() + "/" + f1.GetBottomNumber());
        Console.WriteLine(f2.GetTopNumber() + "/" + f2.GetBottomNumber());
        Console.WriteLine(f3.GetTopNumber() + "/" + f3.GetBottomNumber());

        //3. Verify that you can call each constructor and that you can retrieve and display 
        //the different representations for a few different fractions.

        Console.WriteLine(f1.GetFractionString() + "  ->  " + f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString() + "  ->  " + f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString() + "  ->  " + f3.GetDecimalValue());


    }
}