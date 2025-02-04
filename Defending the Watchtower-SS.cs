// Written By Sam Stuyvenberg // 01/29/2025 //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defending_the_Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");                      // Get a number from user and convert to int.
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)           // Calculates and determines whether a number is even or odd by dividing the original integer by 2.

                Console.WriteLine("Tick");    // If the number is Even "Tick" will print.
            else
                Console.WriteLine("Tock");    // If the number is Odd "Tock" will print.
        }
    }
}
