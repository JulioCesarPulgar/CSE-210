using System;

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);
        Job job3 = new Job("MundoTotal", "Web Developer", 2022, DateTime.Now.Year);

        // Create resume instance
        Resume myResume = new Resume("Daniel Rodriguez");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);
        myResume.AddJob(job3);

        // Display resume
        myResume.Display();
    }
}
