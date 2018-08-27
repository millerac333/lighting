// Create an `Instructor` class with the following properties and fields
namespace Lighting
{
    public class Instructor
    {
        // 1. private fields for first name and last name
        private string _firstName;
        private string _lastName;

        // 2. Public calculated property that returns "Firstname Lastname" of instructor
        public string Name { get => $"{_firstName} {_lastName}"; }

        // 3. Constructor that accepts first name and last name
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student
        public void AssignExcercise(Student student, Excercise exercise)
        {
            student.AssignedExcercises.Add(exercise);
        }

    }
}