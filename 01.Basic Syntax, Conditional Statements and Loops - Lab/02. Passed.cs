namespace _02._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if (num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}