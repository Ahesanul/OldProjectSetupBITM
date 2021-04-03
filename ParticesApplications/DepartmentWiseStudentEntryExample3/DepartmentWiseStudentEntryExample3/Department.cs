using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentWiseStudentEntryExample3
{
    public class Department
    {

         
        public Department()
        {
            Students = new List<Student>();
        }

        public string Code { get; set; }
        public string DepartmentName { get; set; }
        public List<Student> Students { get; set; }

        public Student Student { get; set; }

        public bool AddStudent(Department department, Student student)
        {
            department.Students.Add(student);
            return true;
        }

        public string GetInfo(Department department)
        {
            string message = "";
            message += "Department COde \t\t Department Name" + Environment.NewLine;
            message += department.Code + " \t\t " + department.DepartmentName + Environment.NewLine;
            if (department.Students.Count > 0)
            {
                message += "List of Stdents:" + Environment.NewLine;
                message += "RegNo \t\t Name  \t\t Email \t\t Department" + Environment.NewLine;

                foreach (Student student in department.Students)
                {
                    message += student.RegNo + " \t\t " + student.StudentName + " \t\t " + student.Email + " \t\t " + student.DepartmentName + Environment.NewLine;
                }
            }



            return message;
        }
    }
}
