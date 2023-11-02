namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            result = PrintRepeat(input, n);
            Console.WriteLine(result);
        }

        static string PrintRepeat(string text, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += text;
            }

            return result;
        }
    }
}