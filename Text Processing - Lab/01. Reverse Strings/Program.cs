namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                //char[] reversedWord = word.Reverse().ToArray();
                //Console.WriteLine($"{word} = {string.Join("", reversedWord)}");               
                //word = Console.ReadLine();

                Console.WriteLine($"{word} = {ReverseWord(word)}");
                word = Console.ReadLine();

                //string reversed = string.Empty;
                //for(int i = word.Length - 1; i >= 0; i--)
                //{
                //    reversed += word[i];
                //}
                //Console.WriteLine($"{word} = {reversed}");
                //word = Console.ReadLine();
            }
        }
        static string ReverseWord(string word)
        {
            string reversed = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            return reversed;
        }
    }
}