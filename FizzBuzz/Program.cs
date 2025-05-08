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
            Console.WriteLine("We are playing FizzBuzz! (From 1 to N or up to 100)");
            Console.WriteLine("\nIf divisible by X: Fizz \nif divisible by Y: Buzz \nIf divisible by both X and Y: FizzBuzz\n");
            Console.Write("Enter the numbers X, Y and N seperated with blankspace: ");
            
            string[] xynNumbers = Console.ReadLine().Split();
            int x = int.Parse(xynNumbers[0]);
            int y = int.Parse(xynNumbers[1]);
            int n = int.Parse(xynNumbers[2]);

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
            Console.ReadLine();
        }
    }
}
