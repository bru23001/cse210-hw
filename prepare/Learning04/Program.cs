using System;

class Program
{
    static void Main(string[] args)
    {
        MathHomework mathHomework = new MathHomework("Math HW1", "10/10/2023", "John Doe", "Fractions", "7.3", "3-10, 20-21");
        mathHomework.Display();

        WritingHomework writingHomework = new WritingHomework("Writing HW1", "10/11/2023", "Jane Doe", "European History");
        writingHomework.Display();
    }
}

