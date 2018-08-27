// Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort

// Pick one of the students and write to the Console each exercise that has been assigned to that student

using System;
using System.Collections.Generic;

namespace Lighting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cohort twentySix = new Cohort()
            { CohortNumber = 26 };

            Instructor steve = new Instructor("Steve", "Brownlee");
            Instructor jisie = new Instructor("Jisie", "David");
            Instructor emily = new Instructor("Emily", "Lemmon");
            Instructor jordan = new Instructor("Jordan", "Castelloe");

            Student aaron = new Student("Aaron", "Miller");
            Student shu = new Student("Shu", "Sajid");
            Student jewel = new Student("Jewel", "Ramierez");
            Student elliot = new Student("Elliot", "Huck");
            Student natasha = new Student("Natasha", "Cox");


            twentySix.InstructorList.Add(steve);
            twentySix.InstructorList.Add(jisie);
            twentySix.InstructorList.Add(emily);
            twentySix.InstructorList.Add(jordan);

            twentySix.StudentList.Add(aaron);
            twentySix.StudentList.Add(shu);
            twentySix.StudentList.Add(jewel);
            twentySix.StudentList.Add(elliot);
            twentySix.StudentList.Add(natasha);

            //  Create some exercises
            Excercise ex1 = new Excercise();
            ex1.Name = "ChickenMoneky";
            ex1.Language = "JavaScript";
            ex1.GitHubURL = "wwww.github.com/chickenmonkey";

            Excercise ex2 = new Excercise();
            ex1.Name = "KillHanson";
            ex1.Language = "C#";
            ex1.GitHubURL = "wwww.github.com/killhanson";

            steve.AssignExcercise(jewel, ex1);
            steve.AssignExcercise(jewel, ex2);

            foreach (Excercise excercise in jewel.AssignedExcercises)
            {
                Console.WriteLine($"{jewel.Name}: {excercise.Name}");
            }
        }
    }
}
