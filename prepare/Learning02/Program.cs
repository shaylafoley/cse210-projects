using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Intel";
        job1._startYear = 2021;
        job1._endYear = 2024;

    
    
        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Chase";
        job2._startYear = 2019;
        job2._endYear = 2025;

        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Shayla Foley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}