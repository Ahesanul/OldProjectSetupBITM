using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
   public class Account
    {
        public string accountNo;
        public string customerName;
        public double blances;
       // public int amount;
       //public int damount;
       //public int wamount;
        string report;
        public string createAcc()
        {
            string createAccountName = accountNo + customerName;
            return createAccountName;
        }

        public void Deposit(double amount)
        {
             this.blances = this.blances + amount;
             
           // return this.blances;
        }

        public void Withdraw(double amount)
        {
            this.blances = this.blances - amount;
            //return this.blances;
        }

        public string Report()
        {
            report = "MR." + customerName + "Your Account No IS" + accountNo + " your  balance is" + this.blances + " ";
            return report;
        }
    }
}
