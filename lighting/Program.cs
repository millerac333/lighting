// Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort

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

            twentySix.InstructorList.Add(steve);
            twentySix.InstructorList.Add(jisie);
            twentySix.InstructorList.Add(emily);
            twentySix.InstructorList.Add(jordan);

            twentySix.StudentList.Add(aaron);
            twentySix.StudentList.Add(shu);
            twentySix.StudentList.Add(jewel);
        }
    }
}
