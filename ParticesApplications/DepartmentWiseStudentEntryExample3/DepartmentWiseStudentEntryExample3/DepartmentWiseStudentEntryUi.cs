using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentWiseStudentEntryExample3
{
    public partial class DepartmentWiseStudentEntryUi : Form
    {
        public DepartmentWiseStudentEntryUi()
        {
            InitializeComponent();
        }
        List<Department> Departments = new List<Department>();
        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Code = codeTextBox.Text;
            department.DepartmentName = departmentNameTextBox.Text;
            Departments.Add(department);
            deprartmentComboBox.Items.Add(department.DepartmentName);
            dipartment2ComboBox.Items.Add(department.DepartmentName);
        }

        private void deprartmentComboBox_Click(object sender, EventArgs e)
        {

            
            
        }



        private void deprartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RegNo = regNoTextBox.Text;
            student.StudentName = studentNameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.DepartmentName = departmentNameTextBox.Text;
            
            foreach (Department department in Departments)
            {
                if(department.DepartmentName == deprartmentComboBox.Text)
                {
                    bool flag = department.AddStudent(department,student);
                    break;
                }
            }
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message;
            foreach (Department department in Departments)
            {
                if (department.DepartmentName == dipartment2ComboBox.Text)
                {
                    message = department.GetInfo(department);
                    MessageBox.Show(message);
                    break;
                }
            }
            
        }
    }
}
