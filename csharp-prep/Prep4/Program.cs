using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // variables-------------------------------------------------------
        int intUserNumber = 1;
        List <int> numbers = new List<int>();
        int total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine();

        // loop adding values to list---------------------------------------
        while (!(intUserNumber == 0))
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            intUserNumber = int.Parse(userNumber);

            if (intUserNumber !=0)
            {
                numbers.Add(intUserNumber);
            }
        }

        //Iterating the list to get the total value--------------------------
        foreach (int number in numbers)
        {
            total = total + number; 
        }
        Console.WriteLine();
        Console.WriteLine($"The sum is {total}");

        //Average of values in list------------------------------------------       
        int lenNumbers = numbers.Count;
        float average = ((float)total) / lenNumbers;
        Console.WriteLine();
        Console.WriteLine($"The average is {average}");

        //Max and Min value in list-------------------------------------------
        int max = numbers.Max();
        int min = numbers.Where(n => n > 0).Min();
        Console.WriteLine();
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine();
        Console.WriteLine($"The smallest positive number is {min}");

        //Sorting and printing values-----------------------------------------
        numbers.Sort();
        Console.WriteLine();
        Console.WriteLine("The sorted list is:");
        Console.WriteLine();

        foreach (int sortednumber in numbers)
        {
            Console.WriteLine(sortednumber);
        }




    }
}