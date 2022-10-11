using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            int guess_num = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Guess the number:\t");
                guess_num = Convert.ToInt32(Console.ReadLine());
                if (guess_num < num) Console.WriteLine("Higher");
                if (guess_num > num) Console.WriteLine("Lower");
                if (guess_num == num) { Console.WriteLine("Correct."); break; }
                Console.Write("Remain Attempts:\t");
                Console.WriteLine(7 - i);
            }
            if (guess_num != num)
            {
                Console.WriteLine("Failed.");
                Console.Write("The Number was:\t");
                Console.WriteLine(num);
            }

        }
    }
}
