using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountArchitechure
{
    abstract class Account
    {
        public double AccountBalance { set; get; }
        abstract public double Credit (double amount);
        public abstract double Debit (double amount);
       

    }
}
