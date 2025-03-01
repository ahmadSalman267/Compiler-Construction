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

        // Regular Expression for floating point numbers with max length of 6
        Regex regex1 = new Regex(@"^\d{1,6}(\.\d{1,6})?$");

        foreach (string word in words)
        {
            if (regex1.IsMatch(word) && word.Length <= 6)
            {
                Console.WriteLine("Valid floating-point number: " + word);
            }
            else
            {
                Console.WriteLine("Invalid: " + word);
            }
        }
    }
}
