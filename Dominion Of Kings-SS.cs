using System;

namespace Dominion_Of_Kings
{
    internal class Program
    {
        // Written By Sam Stuyvenberg // 01/29/2025 //

        static void Main(string[] args)
        {
            Console.WriteLine("How many estates do you have?");  // Asks user how many estates they have and converts to int.
            int estateCount = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("How many duchies do you have?");  // Asks user how many duchies they have and converts to int.
            int duchyCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many provinces do you have?");  // Asks user how many provinces they have and converts to int.
            int provinceCount = Convert.ToInt32(Console.ReadLine());

            int total = estateCount * 1 + duchyCount * 3 + provinceCount * 6; // Calculate Total Points.

            Console.WriteLine("Your point total: " + total); // Print Points.
        }
    }
}
