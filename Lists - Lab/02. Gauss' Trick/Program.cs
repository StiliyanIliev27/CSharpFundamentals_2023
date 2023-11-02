namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 80 out of 100 again 
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>();

            bool isOdd = false;

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list.Count % 2 != 0)
                {
                    isOdd = true;
                }

                list[i] += list[list.Count - 1 - i];
                numbers.Add(list[i]);

            }
            if (isOdd)
            {
                numbers.Add(list[list.Count / 2]);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}