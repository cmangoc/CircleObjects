namespace CircleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            Circle circle = new Circle(0);
            circle.GetRadius();
            Console.WriteLine("Diameter: " + circle.CalculateDiameter());
            Console.WriteLine("Circumference: " + circle.CalculateCircumference());
            Console.WriteLine("Area: " + circle.CalculateArea());
            Console.WriteLine();
            circle.Grow();
        }
    }
}