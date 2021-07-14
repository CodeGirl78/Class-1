using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            string input;

            //! Miles Driven//
            Console.WriteLine("Please enter the total number of miles driven: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            //! Gallons of gas consumed//
            Console.WriteLine("Please enter the total amount of gas in gallons consumed: ");
            input = Console.ReadLine();
            gas = double.Parse(input);

            //! Logs the result
            Console.WriteLine("The average miles-per-gallon is: " + (miles / gas) + " mpg.");
        }
    }
}