namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int maxResult = PrintMax(n1, n2);
                Console.WriteLine(maxResult);
            }
            else if (type == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());

                char maxResult = PrintMax(ch1, ch2);
                Console.WriteLine(maxResult);
            }
            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                string maxResult = PrintMax(str1, str2);
                Console.WriteLine(maxResult);
            }
        }

        static int PrintMax(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }

            return n2;
        }
        static char PrintMax(char n1, char n2)
        {
            if (n1 > n2)
            {
                return n1;
            }

            return n2;
        }
        static string PrintMax(string n1, string n2)
        {
            int result = n1.CompareTo(n2);

            if (result > 0)
            {
                return n1;
            }

            return n2;
        }
    }
}