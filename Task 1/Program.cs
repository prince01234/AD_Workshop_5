namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(10001);
            Console.WriteLine($"Account Number: {account.AccountNumber}");

            account.Deposit(5000);
            account.withdraw(1100);
        }
    }
}
    