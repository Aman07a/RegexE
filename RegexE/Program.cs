using System;
using System.Text.RegularExpressions;

namespace RegexE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // Pattern
            // string pattern = @"\d{5}";
            string pattern = @"there";

            // Defining a regular expression with a pattern
            Regex regex = new Regex(pattern);

            // Test string
            string text = "Hi there, my number is 12314";

            // Find hits
            MatchCollection matchCollection = regex.Matches(text);

            // Number of hits
            Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count, text);

            // Amount of hits
            foreach(Match aHit in matchCollection)
            {
                GroupCollection group = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}", group[0].Value, group[0].Index);
                // Console.ReadLine();
            }
        }
    }
}
