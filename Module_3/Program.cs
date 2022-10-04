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

            bool has_alpha = Regex.IsMatch(password, alpha); // Check if the password contains alphabetic characters
            bool has_digit = Regex.IsMatch(password, digit); // Check if the password contains digital numbers.
            bool has_specc = Regex.IsMatch(password, specc); // Check if the password contains special characters.

            Console.Write(has_alpha); // Prints True if password contains alphabetic character otherwise prints False
            Console.WriteLine(has_digit); // Prints True if password contains numeric character otherwise prints False
            Console.WriteLine(has_specc); // Prints True if password contains special character otherwise prints False
        }
    }
}
