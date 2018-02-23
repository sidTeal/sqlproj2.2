using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tisdale_Project_2
{
    static class DatabaseManager
    {
        static string databaseString = "CTASV20R2DRW.tamuct.edu";
        static string databaseNameString = "Initial Catalog = ChristopherFirstAssignment";
        static string userString = "User ID = Christopher";
        static string passwordString = "Password = Tisdale016";

        static string connectionString = String.Format("Data Source= {0}; {1}; {2}; {3};",
            databaseString, databaseNameString, userString, passwordString);

        public static string[] getCustomerNames()
        {
            List<string> customerNames = new List<string>();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT p.LastName + ', ' + p.FirstName FROM ChristopherFirstAssignment.db_owner.Person AS p JOIN Customer c ON c.ID = p.ID";

                con.Open();
                SqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                customerNames.Add(""); //blank value for combo box

                while (reader.Read())
                {
                    customerNames.Add(reader[0].ToString());
                }

                con.Close();


            }
            catch (SqlException)
            {
                MessageBox.Show("The server could not be reached, please try again.", "Connection Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return customerNames.ToArray();

        }

        public static string[] getEmployeeNames()
        {
            List<string> employeeNames = new List<string>();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT p.LastName + ', ' + p.FirstName FROM ChristopherFirstAssignment.db_owner.Person AS p JOIN Employee e ON e.ID = p.ID";

                con.Open();
                SqlDataReader reader;
                reader = sqlCmd.ExecuteReader();

                employeeNames.Add(""); //blank value for combo box

                while (reader.Read())
                {
                    employeeNames.Add(reader[0].ToString());
                }

                con.Close();

                
            }
            catch (SqlException)
            {
                MessageBox.Show("The server could not be reached, please try again.", "Connection Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return employeeNames.ToArray();

        }

        public static DataTable viewCustomer(string lastName, string firstName)
        {
            DataTable dataRecord = null;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM ChristopherFirstAssignment.db_owner.Person WHERE LastName = '" + lastName + "' AND FirstName = '" + firstName +"'";

                con.Open();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);



                dataRecord = new DataTable();
                sqlDataAdap.Fill(dataRecord);

                con.Close();

                
            }
            catch (SqlException)
            {
                MessageBox.Show("The server could not be reached, please try again.", "Connection Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return dataRecord;
        }

        static string AddPersonQueryString()
        {
            string addPersonStringQuery = "";


            return addPersonStringQuery;
        }

        static string AddCustomerQueryString()
        {
            string addCustomerStringQuery = "";


            return addCustomerStringQuery;
        }

        static string AddEmployeeQueryString()
        {
            string addEmployeeStringQuery = "";


            return addEmployeeStringQuery;
        }


    }
}
