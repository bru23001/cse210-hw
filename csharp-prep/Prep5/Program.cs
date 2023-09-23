using System;

class Program
{
    static void Main(string[] args)
    {
        // call function and display welcome message------------------
        DisplayWelcome();

        // call function, return and save the name of the user--------
        string returnedName = PromptUserName();

        // call function, return and save the number entered by user---
        int returnedNumber = PromptUserNumber();

        // call function,uses saved number, squares it, return it and saves it
        int squaredNumber = SquareNumber(returnedNumber);

        // call function, uses saved data to display result message-----
        DisplayResult(returnedName, squaredNumber);

    }

    // function display welcome message-----------------
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!!");
    }

    // function request name of user---------------------
    static string PromptUserName()
    {
        Console.Write("Please, enter your full name: ");
        string functionName = Console.ReadLine();

        return functionName;
    }

    // function request user's favorite number------------
    static int PromptUserNumber()
    {
        Console.Write("Please, enter your favorite number: ");
        int functionNumber = int.Parse(Console.ReadLine());

        return functionNumber;
    }

    // function squares the user's number-------------------
    static int SquareNumber(int functionNumber)
    {
        int squareNumber = functionNumber * functionNumber;

        return squareNumber;
    }

    // function displays the result of operations------------
    static void DisplayResult(string functionName, int functionSquare)
    {
        Console.WriteLine($"{functionName}, the square of your number is {functionSquare}");
    }

}