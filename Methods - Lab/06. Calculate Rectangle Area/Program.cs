namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = 0;

            result = PrintRectangleArea(width, height);
            Console.WriteLine(result);

        }

        static int PrintRectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}