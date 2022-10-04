using System;

namespace M4LA3_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Enter a Positive Number:\t");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
        }
    }
}
