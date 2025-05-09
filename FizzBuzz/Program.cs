using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz implementation in C#
            // Prints numbers from 1 to N (max 100), replacing divisible ones with Fizz, Buzz, or FizzBuzz

            Console.WriteLine("We are playing FizzBuzz! (From 1 to N or up to 100)");
            Console.WriteLine("\nIf divisible by X: Fizz \nif divisible by Y: Buzz \nIf divisible by both X and Y: FizzBuzz\n");

            // Ask user for input values
            Console.Write("Enter the numbers X, Y and N seperated with blankspace: ");

            // Read and parse input values
            string[] xynNumbers = Console.ReadLine().Split();
            int x = int.Parse(xynNumbers[0]);
            int y = int.Parse(xynNumbers[1]);
            int n = int.Parse(xynNumbers[2]);

            // Loop from 1 to N (but not above 100)
            for (int i = 1; i <= n && i <= 100; i++) 
            {
                if (i % x == 0 && i % y == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % x == 0)
                    Console.WriteLine("Fizz");
                else if (i % y == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            // Wait for user to press Enter before closing
            Console.ReadLine();
        }
    }
}
