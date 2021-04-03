using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementAppPractice5
{
    public partial class BankAccountManagementUi : Form
    {
        public BankAccountManagementUi()
        {
            InitializeComponent();
        }

        private List<Customer> customers = new List<Customer>();
        private void CustomerSaveButton_Click(object sender, EventArgs e)
        {
            string nid = idTextBox.Text;
            string name = nameTextBox.Text;
            string number = phoneTextBox.Text;
            string address = addressTextBox.Text;
            Customer customer = new Customer();
            customer.NID = nid;
            customer.CustomerName = name;
            customer.ContactNumber = number;
            customer.Address = address;
            customers.Add(customer);

            customerComboBox.Items.Add(customer.CustomerName);
            transactionCustomerComboBox.Items.Add(customer.CustomerName);
            reportCustomerComboBox.Items.Add(customer.CustomerName);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void AccountSaveButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountNumTextBox.Text;
            string accountType = typeComboBox.Text;
            string customerName = customerComboBox.Text;

            Account account = new Account();
            account.AccountNumber = accountNumber;
            account.AccountType = accountType;

            foreach (var customer in customers)
            {
                if (customer.CustomerName == customerName)
                {
                    customer.AddAccount(customer,account);
                    accountNumTextBox.Text ="";
                    typeComboBox.Text = "";
                    customerComboBox.Text = "";
                    break;
                }
            }


        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            string transactionCustmerName = transactionCustomerComboBox.Text;
            string transactionAccountNumber = accountComboBox.Text;
            double amount = Convert.ToInt32(amountTextBox.Text);


            foreach (var customer in customers)
            {
                if (customer.CustomerName == transactionCustmerName)
                {
                    foreach (var account in customer.Accounts)
                    {
                        if (account.AccountNumber == transactionAccountNumber)
                        {
                        bool flag =     account.Deposit(amount);
                        amountTextBox.Text = "";
                        }
                    }
                    
                    break;
                }
            }

        }

        private void transactionCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transactionCustmerName = transactionCustomerComboBox.Text;
            
            for (int index = 0; index < accountComboBox.Items.Count; index++)
            {
                accountComboBox.Items.RemoveAt(index);
            }

            foreach (var customer in customers)
            {
                if (customer.CustomerName == transactionCustmerName)
                {

                    foreach (var account in customer.Accounts)
                    {
                        accountComboBox.Items.Add(account.AccountNumber);
                    }
                    break;
                }
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {

            string transactionCustmerName = transactionCustomerComboBox.Text;
            string transactionAccountNumber = accountComboBox.Text;
            double amount = Convert.ToInt32(amountTextBox.Text);


            foreach (var customer in customers)
            {
                if (customer.CustomerName == transactionCustmerName)
                {

                    foreach (var account in customer.Accounts)
                    {
                        if (account.AccountNumber == transactionAccountNumber)
                        {
                            bool flag = account.Withdraw(amount);
                            amountTextBox.Text = "";
                        }
                    }
                    break;
                }
            }
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
           string customerName =  reportCustomerComboBox.Text;

           foreach (var customer in customers)
           {
               if (customer.CustomerName == customerName)
               {

                   MessageBox.Show( customer.GetInfo(customer) , "Customer Info" );
                   break;
               }
           }
        }
    }
}
