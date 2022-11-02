using System;

namespace Exercise_1
{
    public class Rectangle : Shape // Inherited from Shape Class
    {
        // Define Constructor with initial length and width
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Defining and Overriding the Properties
        public double Length { get; }

        public double Width { get; }

        public override double Area => Length * Width;

        public override double Perimeter => 2 * Length + 2 * Width;

        public bool IsSquare() => Length == Width;

        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
    }
}
