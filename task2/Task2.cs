//Create a program that takes an integer in decimal, and a new base number system (from 2 to 20) from the command line. 
//Print the original number converted to this system to the console.

using System;

class Test {
    static void Main() {

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

        while (num != 0) {
            int remainder;
            remainder = num % baseNum;
            remainders.Add(remainder);
            remainder = num / baseNum;
        }
        remainders.Reverse();

        Console.Write("Answer is: ");
        foreach(var i in remainders) {
            Console.Write(i);
        }
        
    }
}