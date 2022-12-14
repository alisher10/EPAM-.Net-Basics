using System;
using System.Collections.Generic;

class MaxNumberOfUnequalChars
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
