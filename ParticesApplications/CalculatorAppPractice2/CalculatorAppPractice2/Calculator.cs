using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
   public class Calculator
    {
       // public double firstNo;
       // public double secoundNo;

        public double result;

        public void Add(double firstNo, double secoundNo)
        {
            this.result= firstNo + secoundNo;
           
        }
        public void Subtraction(double firstNo, double secoundNo)
        {
            this.result = firstNo - secoundNo;
           
        }
        public void Multiple(double firstNo, double secoundNo)
        {
            this.result = firstNo * secoundNo;
           
        }
        public void Division(double firstNo, double secoundNo)
        {
            this.result = firstNo / secoundNo;
        
        }
    }
}
