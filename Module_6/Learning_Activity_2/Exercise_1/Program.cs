public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }
    private static int accountNumberSeed = 1234567890;

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Balance = initialBalance;
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        // Use this method to Make Deposit to account, sum amount to balance
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        // Use this method to Make Withdrawal to account, minus amount from balance
    }

    static void Main(string[] args)
    {
        BankAccount bankaccount = new BankAccount("Shazi", 1000);
    }
}