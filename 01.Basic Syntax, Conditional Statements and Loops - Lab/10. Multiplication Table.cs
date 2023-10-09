namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMultiplyTable(n);
        }
        static void PrintMultiplyTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                int mult = n * i;
                Console.WriteLine($"{n} X {i} = {mult}");
            }
        }
    }
}