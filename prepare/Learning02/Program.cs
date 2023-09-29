using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Field Technology Specialist";
        job1._company = "FedEx Office";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Assistant Manager";
        job2._company = "FedEx Office";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Jake Matheson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}