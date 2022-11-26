using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountArchitechure
{
    class CheckingAccount:Account
    {
        double transactionFee;
        public CheckingAccount(double _transcationFee)
        {
            transactionFee= _transcationFee;
        }
        public double TransactionFeeCharge { get; set; }
        public override double Debit(double amount)
        {
            AccountBalance -= amount;
            TransactionFeeCharge += transactionFee;


            return AccountBalance;
        }
        public override double Credit(double amount)
        {
            AccountBalance += amount;
            return AccountBalance;
        }
        public double SubtractFeeFromBalance()
        {
            double newBlance=AccountBalance-TransactionFeeCharge;
            transactionFee =0;
            AccountBalance-= newBlance;
            return AccountBalance;
        }

    }
}
