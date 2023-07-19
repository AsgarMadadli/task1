using System;

namespace Task1.Models
{
    public class Student
    {
        private static int counter = 0;

        public Student(string name, string surname, double grade)
        {
            Name = name;
            Surname = surname;
            Grade = grade;

            Id = counter;
            counter++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
    }
}