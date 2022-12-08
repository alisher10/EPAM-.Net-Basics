//Create a program that takes a sequence of symbols (string) as arguments from the command line 
//and prints the maximum number of unequal consecutive characters per line to the console.

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    { 
        List<char> letter = new List<char>();
        string test = "EPAM";
        foreach (var i in test)
        {
            if (letter.Contains(i))
            {
                break;
            }
            else
            {
                letter.Add(i);
            }
        }

        Console.WriteLine(letter.Count);


    }
}