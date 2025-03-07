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

        // Regular Expression for variables
        Regex regex1 = new Regex(@"^[A-Za-z][A-Za-z0-9]{0,24}$");

        foreach (string word in words)
        {
            if (regex1.IsMatch(word))
            {
                Console.WriteLine("Valid: " + word);
            }
            else
            {
                Console.WriteLine("Invalid: " + word);
            }
        }
    }
}
