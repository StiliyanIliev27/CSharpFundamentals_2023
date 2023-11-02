namespace _01._Randomize_Words
{
    internal class Program
    {      
            static void Main(string[] args)
            {
                PrintRandomWord();
            }
            static void PrintRandomWord()
            {
                string[] words = Console.ReadLine().Split();

                for (int i = 0; i < words.Length; i++)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(i, words.Length);

                    string currentWord = words[i];
                    string wordToSlap = words[randomIndex];

                    words[i] = wordToSlap;
                    words[randomIndex] = currentWord;
                }

                Console.WriteLine(string.Join(Environment.NewLine, words));            
        }
    }
}