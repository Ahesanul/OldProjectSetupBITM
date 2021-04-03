using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigeratorObj = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigeratorObj.MaxWeigthTake = Convert.ToDouble(maxWeightTakeTextBox.Text);
            MessageBox.Show("Max Weigth taken: " + " " + refrigeratorObj.MaxWeigthTake);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigeratorObj.NoOfItems = Convert.ToDouble(itemTextBox.Text);
            refrigeratorObj.UnitOfWeigth = Convert.ToDouble(weightTextBox.Text);

            double currentweigth = refrigeratorObj.CurrentWeigth;
            currentWeightTextBox.Text = currentweigth + " " + "KG";

            double remainnigWeigth = refrigeratorObj.RemaningWeigth;
            remainingWeightTextBox.Text = remainnigWeigth + " " + "KG";
        }
    }
}
