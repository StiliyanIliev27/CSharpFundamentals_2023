namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            while (secondStr.Contains(firstStr))
            {
                int indexOf = secondStr.IndexOf(firstStr);
                secondStr = secondStr.Remove(indexOf, firstStr.Length);
            }
            Console.WriteLine(secondStr);

        }
    }
}