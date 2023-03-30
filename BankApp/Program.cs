using System;
using BankApp.Accounts;

namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();

            calculator.PerformCalculateInterest(new DefaultAccount(500));

            calculator.PerformCalculateInterest(new DefaultAccount(60000));

            calculator.PerformCalculateInterest(new SalaryAccount(50000));
        }
    }
}