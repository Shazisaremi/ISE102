using System;

namespace Exercise_1
{
    public class Circle : Shape // Inherited from Shape Class
    {
        // Define Constructor with initial redius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overriding the Area Property from shape class
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

        // Overriding the Perimeter Property from shape class
        public override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2);

        // Define a circumference, since it's the more familiar term.
        public double Circumference => Perimeter;

        // Returns the Radius of the circle
        public double Radius { get; }

        // Returns the diameter of the circle
        public double Diameter => Radius * 2;
    }
}
