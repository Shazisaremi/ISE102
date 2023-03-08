using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Module_3.Exercise_1
{
    class Code
    {
        public static void main()
        {
            Console.WriteLine("\n--- Running Module 3 Exercise 1 ---");
            Console.WriteLine("Press any key to continue ...\n");
            Console.ReadKey();

            int height;
            Console.WriteLine("Enter your height: ");
            height = int.Parse(Console.ReadLine());
            if (height > 200)
            {
                Console.WriteLine("You are Tall");
            }
            else if (height > 0)
            {
                Console.WriteLine("Your are normal");
            }
            else
            {
                Console.WriteLine("Invalid data");
            }

        }
    }
}
