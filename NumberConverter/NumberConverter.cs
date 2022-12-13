using System;
using System.Collections.Generic;

class NumberConverter
{
    static void Main()
    {

        int num, baseNum;
        string userInput;

        Console.WriteLine("Enter number: ");
        userInput = Console.ReadLine();
        num = Convert.ToInt32(userInput);

        Console.WriteLine("Enter a base: ");
        userInput = Console.ReadLine();
        baseNum = Convert.ToInt32(userInput);
        Console.WriteLine();

        List<int> remainders = new List<int>();

        while (num != 0)
        {
            int remainder;
            remainder = num % baseNum;
            remainders.Add(Convert.ToInt32(remainder));
            num = num / baseNum;
        }
        remainders.Reverse();

        Console.Write("Answer is: ");
        foreach (var i in remainders)
        {
            Console.Write(i);
        }

    }
}