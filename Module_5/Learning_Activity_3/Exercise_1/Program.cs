using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:\t");
            string myString = Console.ReadLine();
            Console.WriteLine(palindrome(myString));

        }

        public static bool palindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] != input[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
