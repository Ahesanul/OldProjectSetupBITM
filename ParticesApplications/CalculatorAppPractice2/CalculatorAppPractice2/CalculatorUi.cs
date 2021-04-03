using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator calculator = new Calculator();
        
        public CalculatorUi()
        {
            InitializeComponent();
           
        }
       
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            double firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNo = Convert.ToDouble(secondNumberTextBox.Text);

            calculator.Add(firstNo,secoundNo);
        

            resultTextBox.Text=Convert.ToString( calculator.result);
            
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            double firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNo = Convert.ToDouble(secondNumberTextBox.Text);

            calculator.Subtraction(firstNo, secoundNo);
            resultTextBox.Text = Convert.ToString(calculator.result);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNo = Convert.ToDouble(secondNumberTextBox.Text);

            calculator.Multiple(firstNo, secoundNo);
            resultTextBox.Text = Convert.ToString(calculator.result);
        }

        private void DivideButton_Click(object sender, EventArgs e)

        {
            double firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNo = Convert.ToDouble(secondNumberTextBox.Text);

            calculator.Division(firstNo, secoundNo);
            resultTextBox.Text = Convert.ToString(calculator.result);
        }
    }
}
