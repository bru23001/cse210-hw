using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address { Street = "123 Main St", City = "Townsville", State = "TS", Zip = "12345" };
        
        Lecture lecture = new Lecture("C# Basics", "Introduction to C#", DateTime.Today.AddDays(2), new TimeSpan(14, 0, 0), address, "Dr. Smith", 100);
        Reception reception = new Reception("C# Meetup", "Networking for C# developers", DateTime.Today.AddDays(4), new TimeSpan(18, 0, 0), address, "rsvp@meetup.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("C# Picnic", "Picnic for C# developers", DateTime.Today.AddDays(10), new TimeSpan(11, 0, 0), address, "Sunny with a chance of rain");

        Console.WriteLine("Lecture Event:\n");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lecture.ShortDescription());

        Console.WriteLine("\nReception Event:\n");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.ShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:\n");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine(outdoorGathering.ShortDescription());
    }
}