using System.Text.RegularExpressions; // Use Regex and Match from this library
using System.Collections.Generic; // Use list from this library
using System;
public class Bank
{
    public string name;
    string student_ID;
    string email;
    string phone;
    int age;
    string password;
    string confirmPass;

    List<Bank> accounts = new List<Bank>();

    public Bank()
    {
        Console.WriteLine("Welcome back choose for menu:");
        Console.WriteLine("1 : login");
        Console.WriteLine("2 : sign up");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("enter your name:");
                this.name = Console.ReadLine();
                Console.WriteLine("enter your student_ID:");
                this.student_ID = Console.ReadLine();
                Console.WriteLine("enter your email:");
                this.email = Console.ReadLine();
                Console.WriteLine("enter your phone:");
                this.phone = Console.ReadLine();
                Console.WriteLine("enter your age:");
                this.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your age:");
                this.password = Console.ReadLine();
                Console.WriteLine("enter your age:");
                this.confirmPass = Console.ReadLine();
                signup(name, student_ID, email, phone, age, password, confirmPass);
                break;
            case 2:
                // write your program here...
                break;
        }
            
    }
    public void signup(string name, string student_ID, string email, string phone, int age, string password, string confirmPass)
    {
        if (password == confirmPass)
        {
            accounts.Add(new Bank { name=this.name, 
                student_ID=this.student_ID , 
                email = this.email , 
                phone = this.phone , 
                age = this.age,
                password = this.password ,
                confirmPass =this.confirmPass });
        }

    }
    public void login(string email, string password)
    {

        // Validate login against stored accounts
        // After login is validated give options to check balance, withdraw, deposit, transfer or exit

    }
    // regMatch can be called in signup method to confirm the signup details are as per requirement.
    public bool regMatch(string pattern, string text)
    {
        Regex regex = new Regex(pattern);
        bool rslt = false;
        Match match = regex.Match(text);
        if (match.Success)
            rslt = true;
        return rslt;
    }
}