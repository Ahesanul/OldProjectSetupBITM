using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB.Model
{
   public class Student
    {
        public int ID { get; set; }
        public string Roll { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Addresses { get; set; }
        public int DistrictID { get; set; }

        public int District { get; set; }
    }
}
