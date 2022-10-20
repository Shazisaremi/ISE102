public class BankAccount
{
    public string Number { get; } // Define number property that just support get
    public string Owner { get; set; } // Define Owner property that support both get and set
    public decimal Balance { get; } // Define Balance property that just support get

    public BankAccount(string name, decimal initialBalance) // Constructor with two inputs : name initial balance
    {
        Owner = name;
        Balance = initialBalance;
    }
    public void MakeDeposit(decimal amount, DateTime date, string note) // Make Deposit method
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) // Make Withdrawal method. 
    {
    }
}