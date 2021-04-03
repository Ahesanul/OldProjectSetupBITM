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
using StudentDB.Model;

namespace StudentDB
{
    public partial class studentDB : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        private SqlCommand sqlCommand;
        private string commandString;

        private Student student;

        public studentDB()
        {
            InitializeComponent();

            connectionString = @"Server=DESKTOP-FGQ12CI\SQLEXPRESS;Database=StudentDB;Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);

            student = new Student();
        }

        private void studentDB_Load(object sender, EventArgs e)
        {
            LoadDistrict();
        }
        private void LoadDistrict()
        {
            sqlConnection.Open();

            commandString = @"select * from Districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                districtComboBox.DataSource = dataTable;
            
            sqlConnection.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            student.Roll = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age =Convert.ToInt32( ageTextBox.Text);
            student.DistrictID =Convert.ToInt32( districtComboBox.SelectedValue);
            student.Addresses = addressTextBox.Text;


            Insert();
        }
        private void Insert()
        {
            sqlConnection.Open();

            commandString = @"INSERT INTO Students( Roll,Name,Age,Addresses,DistrictID)VALUES( '" + student.Roll + "','" + student.Name + "','" + student.Age + "','" + student.Addresses + "','" + student.DistrictID + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            int isExicute;
            isExicute=sqlCommand.ExecuteNonQuery();
            if (isExicute>0)
            {
                MessageBox.Show("SAVE");
            }
            else
            {
                MessageBox.Show("Failed");
            }

            sqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowStudent();
        }
        private void ShowStudent()
        {
            sqlConnection.Open();

            commandString = @"select * from StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
