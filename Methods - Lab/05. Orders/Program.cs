namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    PrintCoffee(quantity);
                    break;
                case "water":
                    PrintWater(quantity);
                    break;
                case "coke":
                    PrintCoke(quantity);
                    break;
                case "snacks":
                    PrintSnacks(quantity);
                    break;
            }
        }
        static void PrintCoffee(int n)
        {
            Console.WriteLine($"{n * 1.50:f2}");
        }
        static void PrintWater(int n)
        {
            Console.WriteLine($"{n * 1.00:f2}");
        }
        static void PrintCoke(int n)
        {
            Console.WriteLine($"{n * 1.40:f2}");
        }
        static void PrintSnacks(int n)
        {
            Console.WriteLine($"{n * 2.00:f2}");
        }
    }
}