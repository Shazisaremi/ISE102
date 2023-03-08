using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3.Exercise_3
{
    class Code
    {
        public static void main()
        {
            Console.WriteLine("\n--- Running Module 3 Exercise 3 ---");
            Console.WriteLine("Press any key to continue ...\n");
            Console.ReadKey();

            Console.WriteLine("Enter geometic object : ");
            string obj = Console.ReadLine();
            switch (obj)
            {
                case "rectangle":
                    Console.WriteLine("Enter length of rectangle : ");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of rectangle : ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Area of rectangle: ");
                    Console.WriteLine(length * width);
                    break;

                case "circle":
                    Console.WriteLine("Enter radius of circle : ");
                    int radius = int.Parse(Console.ReadLine());
                    Console.Write("Area of circle: ");
                    Console.WriteLine(radius * radius * 3.14);
                    break;

                case "triangle":
                    Console.WriteLine("Enter base of triangle : ");
                    int _base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height of triangle : ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Area of triangle: ");
                    Console.WriteLine(_base * height * 0.5);
                    break;

                case "cube":
                    Console.WriteLine("Enter length of cube : ");
                    int len = int.Parse(Console.ReadLine());
                    Console.Write("Area of cube: ");
                    Console.WriteLine(len * len * 6);
                    break;
            }
        }
    }
}
