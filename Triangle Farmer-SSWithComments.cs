// Written By Sam Stuyvenberg // 01/29/2025 //
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is the triangle's width?");         // Obtain width from the user and convert to float.
        string widthText = Console.ReadLine();
        float width = Convert.ToSingle(widthText);
    
        Console.WriteLine("What is the triangle's height?");    // Obtain Height from the user and convert to float.
        string heightText = Console.ReadLine();
        float height = Convert.ToSingle(heightText);

        float area = (width * height) / 2;                      // Calculation done by multiplying the width and the height of the hypothetical triangle and dividing by 2.
        Console.WriteLine("The area is " + area);               // Print Result.
    }
}
