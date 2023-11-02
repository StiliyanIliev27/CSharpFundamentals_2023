namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] commandInfo = command.Split();
                string firstName = commandInfo[0];
                string lastName = commandInfo[1];
                int age = int.Parse(commandInfo[2]);
                string town = commandInfo[3];

                bool studentExists = false;

                foreach (var student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        student.Age = age;
                        student.HomeTown = town;
                        studentExists = true;
                        break;
                    }
                }

                if (!studentExists)
                {
                    Student std = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = town
                    };

                    students.Add(std);
                }

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}