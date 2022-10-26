using System;
using System.Collections.Generic; // Use list from this library

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank();
            while (true)
            {
                Console.WriteLine("Please Choose one option:");
                Console.WriteLine("1: Signup");
                Console.WriteLine("2: Login");
                Console.WriteLine("3: Exit");
                string option = Console.ReadLine();
                if (option == "2")
                {
                    Console.Write("Enter your Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter your Password: ");
                    string pass = Console.ReadLine();
                    obj.login(email, pass);
                }
            }
        }
    }

    public class Bank
    {
        List<Account> accounts = new List<Account>();

        public Bank()
        {
            accounts.Add(new Account("abcxyz@tmail.com", "1234qwerty"));
            accounts.Add(new Account("xxxxxx@tmail.com", "HardPass"));
            accounts.Add(new Account("aaaaaa@tmail.com", "EasyPass"));

        }
        public bool login(string email, string password)
        {
            foreach (var account in accounts)
            {
                if (email == account.email && password == account.pass)
                {
                    Console.WriteLine("Welcome");
                    return true;
                }
                else continue;
            }
            Console.WriteLine("Invalid Credentials, please try again.");
            return false;
        }
    }

    public class Account
    {
        public string email;
        public string pass;
        public Account(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }
    }
}


