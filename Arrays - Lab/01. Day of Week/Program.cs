namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string[] dayOfTheWeek = { "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(dayOfTheWeek[0]);
            }
            else if (n == 2)
            {
                Console.WriteLine(dayOfTheWeek[1]);
            }
            else if (n == 3)
            {
                Console.WriteLine(dayOfTheWeek[2]);
            }
            else if (n == 4)
            {
                Console.WriteLine(dayOfTheWeek[3]);
            }
            else if (n == 5)
            {
                Console.WriteLine(dayOfTheWeek[4]);
            }
            else if (n == 6)
            {
                Console.WriteLine(dayOfTheWeek[5]);
            }
            else if (n == 7)
            {
                Console.WriteLine(dayOfTheWeek[6]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
