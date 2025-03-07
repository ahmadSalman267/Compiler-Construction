using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string containing arithmetic operators:");
        string userInput = Console.ReadLine();

        string pattern = @"[+\-*/]";

        
        MatchCollection matches = Regex.Matches(userInput, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Found arithmetic operators:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No arithmetic operators found.");
 }
   }
}