// Create a `Student` class with the following properties and fields
using System;
using System.Collections.Generic;

namespace lighting
{
    public class Student
    {
        // 1. private fields for first name and last name
        private string _firstName;
        private string _lastName;

        // 2. Public calculated property that returns "Firstname Lastname" of student
        public string Name { get => $"{_firstName} {_lastName}"; }

        // 3. Constructor that accepts first name and last name
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // 4. A public list of exercises
        public HashSet<Excercise> ExcerciseList = new HashSet<Excercise>();

    }
}