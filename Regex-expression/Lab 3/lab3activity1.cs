using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter input:");
        string input = Console.ReadLine();

        
        string[] words = input.Split(' ');

       
        Regex regex1 = new Regex(@"^[A-Za-z][A-Za-z0-9]{0,9}$");

        foreach (string word in words)
        {
            if (regex1.IsMatch(word))
            {
                Console.WriteLine("Valid variable: " + word);
            }
            else
            {
                Console.WriteLine("Invalid: " + word);
            }
        }
    }
}