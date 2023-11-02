namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();

                if (!dict.ContainsKey(wordToLower))
                {
                    dict.Add(wordToLower, 0);
                }

                dict[wordToLower]++;
            }

            foreach (var word in dict)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}