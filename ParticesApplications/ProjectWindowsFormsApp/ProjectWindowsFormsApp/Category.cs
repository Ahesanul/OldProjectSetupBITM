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

namespace ProjectWindowsFormsApp
{
    public partial class Category : Form
    {
 
        class Catagory
        {
            public string Name { set; get; }
        }
        public Category()
        {
            InitializeComponent();
        }
         

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            Catagory catagoryName = new Catagory();
            catagoryName.Name = nameTextBox.Text;

            insert(catagoryName);
            
            Display();
            //for clear text filed
            nameTextBox.Text = "";
            
         

        }
        public void Display()
        {
            try
            {
                //sql connection code
                
                string sqlconnection = @"Server=DESKTOP-C5D8BCN\SQLEXPRESS;Database=StockManagement;Integrated Security=true";
                SqlConnection catagoryConnection = new SqlConnection(sqlconnection);
                //.......................................//
                //show in datagrad view
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Catagories", catagoryConnection);
                DataTable catagoryTable = new DataTable();
                sqlDa.Fill(catagoryTable);
                //method one

                catagoryDataGridView.DataSource = catagoryTable;

                //......................................//
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
         
        }
        private void insert(Catagory catagoryName)
        {
            try
            {   //sql connection code
                string sqlconnection = @"Server=DESKTOP-C5D8BCN\SQLEXPRESS;Database=StockManagement;Integrated Security=true";
                SqlConnection catagoryConnection = new SqlConnection(sqlconnection);
                //.......................................//

                //command Code
                
                string sqlcommand = @"insert into Catagories( Name)values( '"+ catagoryName.Name + "')";
                SqlCommand command = new SqlCommand(sqlcommand, catagoryConnection);
                
                //..................................................//

                //connection Execute Code 
                catagoryConnection.Open();
                
                int isExecuted = 0;
                isExecuted = command.ExecuteNonQuery();
                if (isExecuted>0)
                {
                    MessageBox.Show("SAVE SUCESSFULLY");
                }
                else
                {
                    MessageBox.Show("Please Input Catagory Name");
                }
            

                catagoryConnection.Close();
                
                //.....................................................//
                Display();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void Category_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Update()
        {
            try
            {
                Catagory catagoryName = new Catagory();
                catagoryName.Name = nameTextBox.Text;

                //sql connection code
                string sqlconnection = @"Server=DESKTOP-C5D8BCN\SQLEXPRESS;Database=StockManagement;Integrated Security=true";
                SqlConnection catagoryConnection = new SqlConnection(sqlconnection);
                //.......................................//

                //command Code
                
                string sqlcommand = @"update Catagories set Name='" + catagoryDataGridView.Name + "' where Name ='" + catagoryName.Name + "' ";
                SqlCommand command = new SqlCommand(sqlcommand, catagoryConnection);
                

            }
            catch (Exception u)
            {

                MessageBox.Show(u.Message);
            }
        }
     

        private void catagoryDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("would you like to update DATA");
                saveButton.Text = "update";
                Update();
                //..................................................//catagoryDataGridView.Name


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void dletButton_Click(object sender, EventArgs e)
        {
            try
            {
                //sql connection code

                string sqlconnection = @"Server=DESKTOP-C5D8BCN\SQLEXPRESS;Database=StockManagement;Integrated Security=true";
                SqlConnection catagoryConnection = new SqlConnection(sqlconnection);
                //.......................................//
                //show in datagrad view
                SqlDataAdapter sqlDa = new SqlDataAdapter("delete from Catagories where Name='"+ catagoryDataGridView.SelectedRows+ "'", catagoryConnection);
                DataTable catagoryTable = new DataTable();
                sqlDa.Fill(catagoryTable);
                //method one

                catagoryDataGridView.DataSource = catagoryTable;



            }
            catch (Exception ef)
            {

                MessageBox.Show(ef.Message);
            }

        }

    }
}

