using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUi.Models
{
   public class Student
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DistrictId { get; set; }
        //
        public string DistrictName { get; set; }


    }
}
