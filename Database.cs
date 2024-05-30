using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System
{
    public class Database
    {
        private Database() { }

        private static Database instance;

        //just added two lines to see if git working

        //again

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }

        private static OracleConnection GetDBConnection(string host, int port, String sid, String user, string password)
        {
            string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=" + host + ")(PORT=" + port + "))(CONNECT_DATA=(SERVICE_NAME=" + sid + ")));User Id=" + user + ";Password=" + password;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connString;
            return conn;
        }

        OracleConnection con = GetDBConnection("localhost", 1521, "XEPDB1", "tasnim", "tasnim");


        //public void PlaceOrder(Order order, Customer customer)
        //{

        //}


        public void AddEmployee(Employee employee)
        {
            string insertQuery = "INSERT INTO Employees (Name, Position,Salary, Phone) VALUES (:name, :position,:Salary, :Phone)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = employee.Name;
                command.Parameters.Add(":position", OracleDbType.Varchar2).Value = employee.position;
                command.Parameters.Add(":Salary", OracleDbType.Double).Value = employee.salary;
                command.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = employee.phone;


                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully an Employee added!");
                }
                else
                {
                    MessageBox.Show("Failed to add an Employee!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Registration): " + ex.Message);
                con.Close();

                
            }
        }

        public void LoadEmployeeList(DataGridView dataGridView)
        {

            try
            {
                con.Open();
                string sql = "select * from Employees";
                OracleCommand oracleCommand = new OracleCommand();

                oracleCommand.CommandText = sql;
                oracleCommand.Connection = con;


                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the SELECT query
                OracleDataReader reader = oracleCommand.ExecuteReader();

                dataTable.Load(reader);



                dataGridView.DataSource = dataTable;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); con.Close();
            }
        }
    }
}
