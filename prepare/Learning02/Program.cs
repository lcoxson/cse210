using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU Pathway";
        job1._jobTitle = "Administrative Assistant";
        job1._startYear = 2023;
        job1._endYear = 2024;


        Job job2 = new Job();
        job2._company = "Disney";
        job2._jobTitle = "Mickey Mouse";
        job2._startYear = 1984;
        job2._endYear = 2084;


        Resume mickeyMouse = new Resume();
        mickeyMouse._name = "Mickey Mouse";
        mickeyMouse._jobs.Add(job1);
        mickeyMouse._jobs.Add(job2);

        mickeyMouse.DisplayResume();
    }
}