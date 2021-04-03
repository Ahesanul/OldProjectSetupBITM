using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentUi.Models;

namespace StudentUi
{
    public partial class studentUiForm : Form
    {
        private string connectionstring;
        SqlConnection sqlconnection;

        private string commandstring;
        SqlCommand sqlcommand;

        private Student student;
        public studentUiForm()
        {
            InitializeComponent();
            connectionstring = @"Server=PC-301-19\SQLEXPRESS; Database=StudentDB; Integrated Security=True";
            sqlconnection = new SqlConnection(connectionstring);

            student = new Student();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void studentUiForm_Load(object sender, EventArgs e)
        {
            LoadDistrict();
        }
        private void LoadDistrict()
        {
            
            //
            sqlconnection.Open();

            //
            commandstring = @"select * from Districts";
            sqlcommand = new SqlCommand(commandstring, sqlconnection);
            //
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
            DataTable datatable = new DataTable();
            sqldataadapter.Fill(datatable);
            if(datatable.Rows.Count>0)
            {
                districtComboBox.DataSource = datatable;
              
            }

            sqlconnection.Close();
            //
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            student.RollNo = Convert.ToInt32( rollNoTextBox.Text);
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictId = Convert.ToInt32( districtComboBox.SelectedValue);
            Insert(student);
        }
        private void Insert(Student student)
        {
            sqlconnection.Open();

            commandstring = @"INSERT INTO Students(RollNo,Name,Age,Address,DistrictId) VALUES ('"+student.RollNo+"','"+student.Name+"','"+student.Age+"','"+student.Address+"','"+student.DistrictId+"')";
            sqlcommand = new SqlCommand(commandstring, sqlconnection);

            int isExecuted;
            isExecuted= sqlcommand.ExecuteNonQuery();
            if(isExecuted>0)
            {
                MessageBox.Show("Saved....");
            }
            else
            {
                MessageBox.Show("UnSaved!!!");
            }

            sqlconnection.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowStudent();
        }
        private void ShowStudent()
        {

            sqlconnection.Open();

            commandstring = @"select * from Studentviews";
            sqlcommand = new SqlCommand(commandstring, sqlconnection);
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
            
            DataTable datatable = new DataTable();
            sqldataadapter.Fill(datatable);
            if(datatable.Rows.Count>0)
            {
                showdataGridView.DataSource = datatable;
            }

            sqlconnection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchName();
        } 
        private void SearchName()
        {
            sqlconnection.Open();

            commandstring = @"select * from Students where Name='"+student.Name+"'";
            sqlcommand = new SqlCommand(commandstring, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
            DataTable datatable = new DataTable();
            sqldataadapter.Fill(datatable);
                showdataGridView.DataSource = datatable;
           

            sqlconnection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            sqlconnection.Open();

            commandstring = @"delete from Students where Name='"+ student.Name + "'";
            sqlcommand = new SqlCommand(commandstring, sqlconnection);
            int isExecuted;
            isExecuted = sqlcommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                MessageBox.Show("Record Deleted Successfully...");
            }
            else
            {
                MessageBox.Show("Record Not Deleted ");
            }

            sqlconnection.Close();
        }
    }
}
