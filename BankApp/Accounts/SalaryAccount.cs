using System;

namespace BankApp.Accounts
{
    class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        
        public double Interest { get; set; }
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"процентная ставка равна {Interest}");
        }
    }
}