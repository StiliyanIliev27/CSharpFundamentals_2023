using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<date>\d{2})(.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"Day: {match.Groups["date"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}