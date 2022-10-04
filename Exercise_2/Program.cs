using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press Enter Key to Exit ...");
            Console.ReadLine();
        }
    }
}
