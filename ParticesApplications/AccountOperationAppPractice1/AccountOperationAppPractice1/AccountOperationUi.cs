using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        Account acc = new Account();
       
        private void CreateButton_Click(object sender, EventArgs e)
        {
            acc.accountNo = accountNoTextBox.Text;
            acc.customerName = customerNameTextBox.Text;
            acc.createAcc();
            MessageBox.Show("Your Account Created");
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            //acc.amount =Convert.ToInt32( amountTextBox.Text);
            double amount = Convert.ToInt32(amountTextBox.Text);
            acc.Deposit(amount);
           // MessageBox.Show("your deposit blances");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            //acc.amount = Convert.ToInt32(amountTextBox.Text);
            double amount = Convert.ToInt32(amountTextBox.Text);
            acc.Withdraw(amount);
            //MessageBox.Show("your deposit blances" + acc.wamount);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acc.Report());
        }
    }
}
