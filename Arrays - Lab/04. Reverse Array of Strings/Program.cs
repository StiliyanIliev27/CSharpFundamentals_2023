namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();


            for (int i = 0; i < strings.Length / 2; i++)
            {
                string firstDigit = strings[i];
                string lastDigit = strings[strings.Length - 1 - i];

                strings[i] = lastDigit;
                strings[strings.Length - 1 - i] = firstDigit;

            }

            Console.Write(string.Join(" ", strings));
        }
    }
}