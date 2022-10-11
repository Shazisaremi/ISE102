using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int answer1 = Sum(num1, num2);
            int answer2 = Sub(num1, num2);
            int answer3 = Mult(num1, num2);
            double answer4 = Div(num1, num2);
            Console.WriteLine("Sum: {0}\n" + "Difference: {1} \n" + "Multiplication: {2} \n" + "Division: {3} \n", answer1, answer2, answer3, answer4);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
