namespace Task
{
    internal class Student
    {
        private string name;
        private string surname;
        private double grade;

        public Student(string name, string surname, double grade)
        {
            this.name = name;
            this.surname = surname;
            this.grade = grade;
        }

        public int Id { get; internal set; }
    }
}