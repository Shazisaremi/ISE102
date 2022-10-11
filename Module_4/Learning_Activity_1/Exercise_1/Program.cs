using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Press Enter Key to Exit ...");
            Console.ReadLine();
        }
    }
}
