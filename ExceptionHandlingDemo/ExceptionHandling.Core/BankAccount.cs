using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling.Core
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.", nameof(initialBalance));
            }
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
            }

            if (amount > Balance)
            {
                //break point here
                throw new InsufficientFundsException(
                    $"Attempted to withdraw {amount:C}. Current balance is only {Balance:C}."
                );
            }

            Balance -= amount;
        }
    }
}