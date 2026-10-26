using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        public decimal Balance;
        
        public BankAccount(decimal balance)
        {
            if (balance < 0) { throw new ArgumentOutOfRangeException("Invalid balance"); }
            else { Balance = balance;  }
        }
        public BankAccount()
        {
            Balance = 0;
        }

        public void Pay(decimal amount)
        {
            if ((amount < 0) || (amount > Balance)) { throw new ArgumentOutOfRangeException("Invalid operation or mot enough money"); }
            else { Balance -= amount; }
        }

        public void Add(decimal amount)
        {
            if (amount < 0) { throw new ArgumentOutOfRangeException("negative amount"); }
            else { Balance += amount; }
        }

    }
}
