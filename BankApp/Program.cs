using System;
using BankApp.Accounts;

namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();

            var account1 = new DefaultAccount() { Balance = 500 };

            var account2 = new DefaultAccount() { Balance = 60000 };

            var account3 = new SalaryAccount() { Balance = 10000 };

            calculator.PerformCalculateInterest(account1);
            calculator.PerformCalculateInterest(account2);
            calculator.PerformCalculateInterest(account3);
        }
    }
}