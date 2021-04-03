using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    public class Salary
    {
        public double Basic { get; private set; }
        private int MedicalPersentage { get;  set; }
        private int ConvenancePersentage { get;  set; }
        public int NumberOfIncrement { get; private set; }

        public Salary(double amount,int medical, int convenance) {
            this.Basic = amount;
            this.MedicalPersentage = medical;
            this.ConvenancePersentage = convenance;
        }
        public bool Increment(int rate)
        {
            this.Basic = this.Basic + (this.Basic * rate / 100);
            this.NumberOfIncrement++;
            return true;
        }
        public double GetMedicalAmount()
        {
           return ( this.Basic * MedicalPersentage / 100);
        }
        public double GetConvenanceAmount()
        {
            return (this.Basic * this.ConvenancePersentage / 100);
        }
        public double GetTotalSalary()
        {
            return this.Basic + GetMedicalAmount() + GetConvenanceAmount();
        }
        
    }
}
