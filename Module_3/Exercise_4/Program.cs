using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3.Exercise_4
{
    class Code
    {
        public static void main()
        {
            Console.WriteLine("\n--- Running Module 3 Exercise 4 ---");
            Console.WriteLine("Press any key to continue ...\n");
            Console.ReadKey();

            // Write a C# program to check two given numbers where one is less than 50 and other is greater than 100.
            Console.WriteLine("Input a first number(<50): ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a second number(>100): ");
            int num_2 = int.Parse(Console.ReadLine());
            if (num_1 < 50 & num_2 > 100)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // Write a C# program to check if an integer (from the two given integers) is in the range -5 to 5.
            Console.WriteLine("Input a first number: ");
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a second number: ");
            num_2 = int.Parse(Console.ReadLine());
            if (num_1 < 5 | num_1 > -5)
            {
                if (num_2 < 5 | num_2 > -5)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
