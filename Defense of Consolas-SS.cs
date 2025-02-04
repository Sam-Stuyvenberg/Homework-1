// Written By Sam Stuyvenberg // 01/29/2025 //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Target Row? ");                  // Get input from user to convert to int row
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");                   // Get input from user to convert to int column
            int column = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;   // Set color to green for aesthetics
            Console.WriteLine($"({row}, {column - 1})");   // Calculation For Coordinates
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();  // Beep so signify completion.
        }
    }
}
