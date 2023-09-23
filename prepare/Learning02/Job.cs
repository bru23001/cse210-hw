using System;

// Job class-----------------------------------------------------------
public class Job
{
  // member variables--------------------------------------------------
  public string _jobTitle;
  public string _company;
  public int _startYear;
  public int _endYear;

  // Job class Display method-------------------------------------------
  public void DisplayJob()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}