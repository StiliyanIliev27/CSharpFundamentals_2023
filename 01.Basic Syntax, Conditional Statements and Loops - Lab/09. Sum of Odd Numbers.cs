namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintOddNumbers(n);
        }
        static void PrintOddNumbers(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}