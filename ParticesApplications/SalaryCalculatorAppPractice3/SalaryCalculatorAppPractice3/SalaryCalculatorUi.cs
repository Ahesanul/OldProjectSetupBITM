using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        Salary salary = new Salary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            salary.employeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToInt32(basicAmountTextBox.Text);

            int houseRent = Convert.ToInt32(homeRentTextBox.Text);
            int medicalRent = Convert.ToInt32(medicalAllowanceTextBox.Text);

            salary.TotalSalary(houseRent, medicalRent);

            MessageBox.Show("Mr." + salary.employeName + " your salary is: " + salary.totalSalary );
        }
    }
}
