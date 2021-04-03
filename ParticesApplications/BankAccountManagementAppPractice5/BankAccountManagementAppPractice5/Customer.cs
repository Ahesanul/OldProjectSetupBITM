using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementAppPractice5
{
    public class Customer
    {
        public Customer()
        { 
            Accounts = new List<Account>();
        }
            
        public string NID { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public List<Account> Accounts { get; set; }

        public bool AddAccount(Customer customer, Account account)
        {
            customer.Accounts.Add(account);
            return true;
        }


        public string GetInfo(Customer customer)
        {
            double totalbalance = 0;
            string message = "";
            message += "Customer: "+customer.CustomerName +Environment.NewLine;
            if (customer.Accounts.Count > 0)
            {
                message += "AC No \t\t Type \t\t Balance"+ Environment.NewLine;
            }

            foreach (var account in customer.Accounts)
            {
                message += account.AccountNumber+" \t\t "+account.AccountType+" \t\t "+account.Balance.ToString() + Environment.NewLine;
                totalbalance+=account.Balance;
            }
            message += "Total :" + totalbalance.ToString() + Environment.NewLine;
            return message;
        }

    }
}
