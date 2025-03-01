using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter input:");
        string input = Console.ReadLine();

        // Split the input on the basis of space
        string[] words = input.Split(' ');

        
        Regex regex1 = new Regex(@"^[0-9][0-9]*(([\.][0-9][0-9]*)?([e][+-][0-9][0-9]*)?)?$");

        foreach (string word in words)
        {
            if (regex1.IsMatch(word))
            {
                Console.WriteLine("Valid number: " + word);
            }
            else
            {
                Console.WriteLine("Invalid: " + word);
            }
        }
    }
}