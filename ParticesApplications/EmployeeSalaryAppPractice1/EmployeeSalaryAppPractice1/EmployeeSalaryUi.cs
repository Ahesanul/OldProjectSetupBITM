using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryAppPractice1
{
    public partial class EmployeeSalaryUi : Form
    {
        public EmployeeSalaryUi()
        {
            InitializeComponent();
        }
        Employee employee;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            string name = nameTextBox.Text;
            double amount = Convert.ToDouble(basicTextBox.Text);
            int medical = Convert.ToInt32(medicalTextBox.Text);
            int conv = Convert.ToInt32(conveyanceTextBox.Text);

            Salary salary = new Salary(amount,medical,conv);

            employee = new Employee();
            employee.Id = id;
            employee.Name = name;
            employee.Salary = salary;


        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int increment = Convert.ToInt32(increaseTextBox.Text);

            bool flag = employee.Salary.Increment(increment);
            if (flag)
            {
                increaseTextBox.Text = "";
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            noOfIncrementsTextBox.Text = employee.Salary.NumberOfIncrement.ToString();
            showBasicTextBox.Text = employee.Salary.Basic.ToString();
            showMedicalTextBox.Text = employee.Salary.GetMedicalAmount().ToString();
            showConveyanceTextBox.Text = employee.Salary.GetConvenanceAmount().ToString();
            showTotalTextBox.Text = employee.Salary.GetTotalSalary().ToString();



        }
    }
}
