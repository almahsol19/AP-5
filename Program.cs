using System;
using System.Threading;

public class LedBlinker
{
    public static void Main(string[] args)
    {
        int numIterations = 5;

        for (int i = 0; i < numIterations; i++)
        {
            Console.WriteLine("Enter 1 for L (Red), 0 for H (Green):");
            if (int.TryParse(Console.ReadLine(), out int ledChoice))
            {
                if (ledChoice == 1 || ledChoice == 0)
                {
                    string ledColor = (ledChoice == 1) ? "L" : "H";
                    Console.WriteLine($"{ledColor} ON");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{ledColor} OFF");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 0 or 1.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine();

        }
    }
}