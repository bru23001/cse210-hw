/*
1) Follow the same pattern as before by creating a new file for the WritingAssignment class.
2) Create the class and set up the inheritance relationship.
3) Add the member variables and set up the constructor as you did for the MathAssignment class.
4) Add the GetWritingInformation() method.
5) Notice that this method needs to access the _studentName variable defined in the base class. 
   Even though WritingAssignment class inherited this attribute, it is private, so you cannot 
   access it directly in the derived class. To get the data you need for the method you can 
   either make the variable protected in the base class, or you can create a public 
   GetStudentName method to return it.
*/


// Derived class for Writing assignments
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title + " by "+ _studentName;    
    }

}
