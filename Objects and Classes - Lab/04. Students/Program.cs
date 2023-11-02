namespace _04._Students
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
                string city = commandInfo[3];

                Student std = new Student();

                std.FirstName = firstName;
                std.LastName = lastName;
                std.Age = age;
                std.City = city;

                students.Add(std);

                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == cityName)
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

        public string City { get; set; }
    }
}