using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string symbol = "";

        Console.Write("What's your grade %? ");
        string gradeImputUser = Console.ReadLine() ;
        int gradeInt = int.Parse(gradeImputUser);

        if (gradeInt >= 90)
        {
            letter = "A";

            if (gradeInt <= 93)
            {
                symbol = "-";
            }
            
        }

        else if (gradeInt >= 80)
        {
            letter = "B";

            if (gradeInt <= 83)
            {
                symbol = "-";
            }
            else if (gradeInt >= 87)
            {
                symbol = "+";
            }
        }

        else if (gradeInt >= 70)
        {
            letter = "C";

            if (gradeInt <= 73)
            {
                symbol = "-";
            }
            else if (gradeInt >= 77)
            {
                symbol = "+";
            }
        }

        else if (gradeInt >= 60)
        {
            letter = "D";

            if (gradeInt <= 63)
            {
                symbol = "-";
            }
            else if (gradeInt >= 67)
            {
                symbol = "+";
            }
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{symbol}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }

        else
        {
            Console.WriteLine("Sorry, but you don't meet the requirements to pass the class.");
        }

    }
}