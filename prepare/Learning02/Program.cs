using System;

class Program
{
    static void Main(string[] args)
    {
        // job1 instance of Job class--------------
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2003;
        job1._endYear = 2010;


        // job2 instance of Job class--------------
        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Adobe";
        job2._startYear = 2010;
        job2._endYear = 2022;


        // resume instance of Resume class----------
        Resume victorResume = new Resume();
        victorResume._name = "Victor J. Brun";
        victorResume._jobs.Add(job1);
        victorResume._jobs.Add(job2);

        victorResume.DisplayResume();
    }

}