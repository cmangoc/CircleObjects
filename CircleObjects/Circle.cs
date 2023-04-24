using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }
        public double CalculateCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }
        public void Grow()
        {
            Console.WriteLine("Should the circle grow? (y/n): ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                radius = 2 * radius;
                Console.WriteLine("Diameter: " + CalculateDiameter());
                Console.WriteLine("Circumference: " + CalculateCircumference());
                Console.WriteLine("Area: " + CalculateArea());
                Console.WriteLine();
                Grow();
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye. The circle's final radius is " + radius);
            }
            else
            {
                Console.WriteLine("I didn't understand that, lets try again.");
                Grow();
            }
        }
        public double GetRadius()
        {
            try
            {
                Console.WriteLine("Enter Radius: ");
                radius = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input: Not a number, try again.");
                GetRadius();
            }
            return radius;
        }
    }
}
