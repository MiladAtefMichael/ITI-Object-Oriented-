using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountArchitechure
{
    class SavingAccount:Account
    {
        public double InterestRate { get; set; }
        public override double Debit(double amount)
        {
            AccountBalance-=amount;
            return AccountBalance;
        }
        public override double Credit(double amount)
        {
            AccountBalance += amount;
            return AccountBalance;
        }
        public double CalculateInterest() 
        {
            double Interest = AccountBalance * InterestRate;
            return Interest;
        } 
        public void AddInterrest()
        {
            AccountBalance += CalculateInterest();
        }

    }
}
