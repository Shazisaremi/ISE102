using System;

namespace M4LA2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base of the multiples:\t");
            int m_base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of the multiples:\t");
            int m_num = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i <= m_num; i++)
            {
                Console.Write(i*m_base);
                Console.Write(", ");
            }
        }
    }
}
