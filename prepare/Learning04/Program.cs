using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment1 = new Assignment("Victor J. Brun", "C# Language: Abstration");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Elvis Presley", "C# Language: Encapsulation", "Getters and Setters ","3.a, 5.b-d");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Freddy Mercury", "C# Language: Inheritance", "Liskov Substitution Principle");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}

