using System;

namespace StudioAreaofaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the radius
            Console.WriteLine("Please enter the radius of the circle: ");

            // Get the radius from the user
            var radiusInput = Console.ReadLine();

            // Convert the text input to double
            var radius = double.Parse(radiusInput);

            // Compute the area (A = pi * r * r)
            var area = Math.Round(Math.PI * radius * radius, 3);

            // Print the area of the circle
            Console.WriteLine($"The area of a circle with the radius of {radius} is: {area}");
        }
    }
}