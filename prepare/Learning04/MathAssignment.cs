/*
1) Create a new file for the MathAssignment class.
2) Create this class and make sure to specify that it inherits from the base Assignment class.
3) Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you 
   inherited from the base class.
4) Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the 
   base class attributes that way.
5) Add the GetHomeworkList() method.
*/

using System;

// Derived class for Math assignments
public class MathAssignment : Assignment
{
    private string _textbookSection; 
    private string _problems;
    

    public MathAssignment(string textbookSection, string problems) : base(studentName, topic)
    {
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }
    }
    public string GetSummary()
    {
        return $_studentName + "-"+ _topic\n_textbookSection + _problems;    
    }
    /*
    public override void Display()
    {
        Console.WriteLine($"Math Homework: {Title}, Due: {DueDate}, Student: {StudentName}, Topic: {Topic}, Section: {TextbookSection}, Problems: {Problems}");
    }
    */
}
