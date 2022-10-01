using System;
using Module_3;
using System.Text.RegularExpressions;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise_1.Code.main();

            //Exercise_2.Code.main();

            //Exercise_3.Code.main();

            //Exercise_4.Code.main();

            string alpha = @"[a-zA-Z]"; // Alphabetic characters Regex
            string digit = @"\d"; // Digital Characters Regex
            string specc = @"\W"; // Special Characters Regex

            string password = "Hello World";

            bool has_alpha = Regex.IsMatch(password, alpha);
            bool has_digit = Regex.IsMatch(password, digit);
            bool has_specc = Regex.IsMatch(password, specc);

            Console.WriteLine(has_alpha);
            Console.WriteLine(has_digit);
            Console.WriteLine(has_specc);
        }
    }
}
