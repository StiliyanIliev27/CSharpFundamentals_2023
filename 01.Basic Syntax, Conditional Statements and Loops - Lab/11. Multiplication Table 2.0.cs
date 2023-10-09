namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startIndex = int.Parse(Console.ReadLine());
            PrintMultiplyTable(n, startIndex);
        }
        static void PrintMultiplyTable(int n, int startIndex)
        {
            if (startIndex > 10)
            {
                int multMoreThanTen = n * startIndex;
                Console.WriteLine($"{n} X {startIndex} = {multMoreThanTen}");
            }
            else
            {
                for (int i = startIndex; i <= 10; i++)
                {
                    int mult = n * i;
                    Console.WriteLine($"{n} X {i} = {mult}");
                }
            }
        }
    }
}