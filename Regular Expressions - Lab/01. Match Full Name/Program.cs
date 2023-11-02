using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine(string.Join(" ", matchCollection));

            //foreach (Match match in matchCollection)
            //{
            //    Console.Write(match.Value + " ");
            //}
        }
    }
}