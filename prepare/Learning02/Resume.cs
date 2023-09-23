using System;

// Resume class-----------------------------------------------------------
public class Resume
{
  //member variables-------------------------------------------------------
  public string _name;

  public List<Job> _jobs = new List<Job>();

  //display method for Resume class----------------------------------------
  public void DisplayResume()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("Experience:");
    foreach (Job eachJob in _jobs)
    {
      eachJob.DisplayJob();
    }
  }

}