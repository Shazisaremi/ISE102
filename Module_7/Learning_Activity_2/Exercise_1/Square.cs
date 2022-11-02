using System;

namespace Exercise_1
{
    public class Square : Shape // Inherited from Shape Class
    {
        // Define Constructor with initial length
        public Square(double length)
        {
            Side = length;
        }

        // Defining and Overriding the Properties
        public double Side { get; }

        public override double Area => Math.Pow(Side, 2);

        public override double Perimeter => Side * 4;

        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
    }
}
