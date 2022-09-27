using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3.Exercise_2
{
    class Code
    {
        public static void main()
        {
            Console.WriteLine("\n--- Running Module 3 Exercise 2 ---");
            Console.WriteLine("Press any key to continue ...\n");
            Console.ReadKey();

            Console.WriteLine("Enter geometic object : ");
            string obj = Console.ReadLine();
            if (obj == "rectangle")
            {
                Console.WriteLine("Enter length of rectangle : ");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of rectangle : ");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Area of rectangle: ");
                Console.WriteLine(length * width);
            }
            else if (obj == "circle")
            {
                Console.WriteLine("Enter radius of circle : ");
                int radius = int.Parse(Console.ReadLine());
                Console.Write("Area of circle: ");
                Console.WriteLine(radius * radius * 3.14);

            }
            else if (obj == "triangle")
            {
                Console.WriteLine("Enter base of triangle : ");
                int _base = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter height of triangle : ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Area of triangle: ");
                Console.WriteLine(_base * height * 0.5);
            }
            else if (obj == "cube")
            {
                Console.WriteLine("Enter length of cube : ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Area of cube: ");
                Console.WriteLine(length * length * 6);
            }
        }
    }
}
