using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
   public class Person
    {
       public string firstName;
       public string middleName;
       public string lastName;

       // string fullName;
        string reverseName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string GetFullName()
        {
           return firstName+" " + middleName+" " + lastName;
           // return fullName;
        }
        public string ReverseName()
        {

            reverseName = "";
            for (int count = GetFullName().Length - 1; count >= 0; count--)
            {
                reverseName += GetFullName()[count];
            }
            return reverseName;
        }

    }
}
