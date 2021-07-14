using System;

namespace AreaBonusDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var radiusCharStr = string.Empty;
            var radius = 0d;
            
            // Loop until user enters a positive number
            do
            {
                Console.Write("Please enter a radius: ");

                // Get the radius from the user
                radiusCharStr = Console.ReadLine();

                // Convert text input into a double
                radius = double.Parse(radiusCharStr);

                // If user enters a negative number, print an error message
                if (radius < 0)
                {
                    Console.WriteLine("Sorry, you can't enter a negative number.");
                }

            } while (radius < 0);

            // Compute the area (A = pi * r * r)
            var area = Math.Round(Math.PI * radius * radius, 3);

            // Print the area of the circle
            Console.WriteLine($"The area of a circle with a radius of {radius} is: {area}");
        }
    }
}