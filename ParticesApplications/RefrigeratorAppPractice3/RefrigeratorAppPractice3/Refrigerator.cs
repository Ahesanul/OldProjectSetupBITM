using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {   
        //Field to access---Has
        private double maxWeigthTake;
        private double noOfItems;
        private double unitOfWeigth;

        //Property all
        public double MaxWeigthTake
        {
            get { return maxWeigthTake; }
            set { maxWeigthTake = value; }
        }

        public double NoOfItems
        {
            get { return noOfItems; }
            set { noOfItems = value; }
        }

        public double UnitOfWeigth
        {
            get { return unitOfWeigth; }
            set { unitOfWeigth = value;}
        }
        public double CurrentWeigth
        {
            get {return GetCurrentWeigth(); }
        }
        public double RemaningWeigth
        {
            get { return GetRemaningWeigth(); }
        }
        //Can---Method
        private double GetCurrentWeigth()
        {
            double currentWeigth;
            currentWeigth = NoOfItems * UnitOfWeigth;
            return currentWeigth;
        }
        private double GetRemaningWeigth()
        {
            double remaningWeigth;
            remaningWeigth = MaxWeigthTake - (NoOfItems * UnitOfWeigth);
            return remaningWeigth;
        }


    }
}
