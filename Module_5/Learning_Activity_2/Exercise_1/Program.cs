using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "789xyzw";
            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[myString.Length - i - 1]);
            }
        }
    }
}
