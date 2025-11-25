using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class BankAccount
    {
        private int accountNumber;
        private double balance;

        public BankAccount(int accountNumber)
        {
            this.AccountNumber = accountNumber;
        }

        public int AccountNumber { get; }
        public double Balance
        {
            get { return Balance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                balance = value;

            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            balance += amount;
            Console.WriteLine($"You have successfully deposited {amount}. New balance is {balance}");
        }

        public void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficinet funds!");
            }
            balance -= amount;
            Console.WriteLine($"You have successfully withdrawn {amount}. New balance is {balance}");
        }
    }

}
