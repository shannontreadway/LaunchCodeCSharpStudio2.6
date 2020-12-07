using System;

namespace CalculateAreaAndCircumferenceOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle? ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            Console.WriteLine("The area of a circle of radius {0} is: {1}", radius, area);

            double circumference = Math.Round(Math.PI * 2 * radius, 3);
            Console.WriteLine("The circumference of a circle of radius {0} is: {1}", radius, circumference);

            Console.WriteLine("How many miles does your car get per gallon?");
            double mpg = double.Parse(Console.ReadLine());
            double gallonsNeeded = Math.Round(circumference / mpg, 4);
            Console.WriteLine("It would take {0} gallons to travel around a circle with radius {1}", gallonsNeeded, radius);
        }
    }
}
