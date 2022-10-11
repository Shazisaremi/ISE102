using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your number:\t");
            int maxi = Convert.ToInt32(Console.ReadLine());
            even_or_odd(maxi);
        }

        public static void even_or_odd(int maxi)
        {
            for (int i=0; i <= maxi; i++)
            {
                if (i % 2 == 0) Console.WriteLine("{0} is an even number", i);
                else Console.WriteLine("{0} is an odd number", i);
                Console.WriteLine("\n");
            }
        }
    }
}
