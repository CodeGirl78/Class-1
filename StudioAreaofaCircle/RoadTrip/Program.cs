using System;

namespace RoadTrip
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

            // Ask the user to enter miles per gallon for their car
            Console.WriteLine("How many miles per gallon does your car get?");

            // Get the miles per gallon for their car from the user
            var milesperGal = Console.ReadLine();

            // Print gallons of gas for going around the circle.
            string value = $"You will use {milesperGal / area} gallons of gas to go around the circle with a radius of {area}";
            Console.WriteLine(value);
        }
    }
}