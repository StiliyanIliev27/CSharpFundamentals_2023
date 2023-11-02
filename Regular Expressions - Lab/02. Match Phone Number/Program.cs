using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            Console.WriteLine(string.Join(", ", matchCollection));
        }
    }
}