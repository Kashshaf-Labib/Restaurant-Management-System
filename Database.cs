using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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

        }
    }
}
