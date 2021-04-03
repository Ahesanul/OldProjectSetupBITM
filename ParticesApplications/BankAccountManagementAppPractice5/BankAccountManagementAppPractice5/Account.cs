using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementAppPractice5
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; private set; }
        public bool Deposit( double amount)
        {
            this.Balance = this.Balance + amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
            return true;
        }
    }
}
