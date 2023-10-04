/*
1) Begin by creating a new file and a class for your base Assignment class.
2) Add the attributes as private member variables.
   _studentName : string
   _topic : string 
3) Create a constructor for this class that receives a student name and topic and sets the member variables.
4) Add the method for GetSummary() to return the student's name and the topic.
   GetSummary() : string 

*/


// Base class
public class Assignment
{
    protected string _studentName; 
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return "Name: " + _studentName + " -  topic: "+ _topic;
    }
}
