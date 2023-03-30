using BankApp.Accounts;
using System;

namespace BankApp
{
    class Calculator
    {
        public void PerformCalculateInterest(IAccount accountType)
        {
            accountType.CalculateInterest();
        }
    }
}