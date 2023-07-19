namespace Task1.Services
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();

        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());

                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Added student successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, an error occurred. {ex.Message}");
            }
        }

        public static void MenuUpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                var existingStudent = studentService.GetStudents().Find(s => s.Id == id);

                if (existingStudent == null)
                {
                    Console.WriteLine("Student with the given ID not found!");
                    return;
                }

                Console.WriteLine("Enter new name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter new surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter new grade:");
                double grade = double.Parse(Console.ReadLine());

                existingStudent.Name = name;
                existingStudent.Surname = surname;
                existingStudent.Grade = grade;

                Console.WriteLine("Updated student successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, an error occurred. {ex.Message}");
            }
        }

        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, an error occurred. {ex.Message}");
            }
        }

        public static void MenuFindStudentByName()
        {
            Console.WriteLine("Enter student's name:");
            string nameToSearch = Console.ReadLine();

            var students = studentService.GetStudents().FindAll(s => s.Name.ToLower() == nameToSearch.ToLower());

            if (students.Count == 0)
            {
                Console.WriteLine("No students found with the given name.");
                return;
            }

            Console.WriteLine("Students with the given name:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }
    }
}