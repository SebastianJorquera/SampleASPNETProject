using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using SampleASPNETProject.DataModels;

namespace SampleASPNETProject.DataAccessLayer
{
    public class CustomerTier
    {
        private string connectionString;

        public CustomerTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }
        /// <summary>
        /// gets the data from the customerinformation table
        /// </summary>
        /// <returns>lif of customer Type.</returns>
        public List<Customer> getAllCustomers()
        {
            List<Customer> customerList = null;
            Customer customer;
            string query;
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader reader;
            query = "SELECT * FROM CustomerInformation;";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    customerList = new List<Customer>();
                    while(reader.Read())
                    {
                        customer = new Customer();
                        customer.custID = (int)reader["CustomerID"];
                        customer.firstName = reader["FirstName"].ToString();
                        customer.middleName = reader["MiddleName"].ToString();
                        customer.lastName = reader["LastName"].ToString();
                        customer.address = reader["Adress"].ToString();
                        customer.adress2 = reader["Adress2"].ToString();
                        customer.city = reader["City"].ToString();
                        customer.state= reader["State"].ToString();
                        customer.zip = (int)reader["Zip"];

                        customerList.Add(customer);
                    }
                }
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return customerList;
        }
        /// <summary>
        /// This is a method that will return all customers from the customerInformation table.
        /// </summary>
        /// <param name="theCustomer">Customer information as cutomer type</param>
        /// <returns>true or on success</returns>
        public bool insertCustomer(Customer theCustomer)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string query;
            bool success = false;
            int rows;

            query = "INSERT INTO CustomerInformation (FirstName, MiddleName, LastName, Address, Address2, City, State, Zip) VALUES(@FName, @MName, @LName, @Address, @Address2, @City, @State, @Zip);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@FName", SqlDbType.VarChar, 50).Value = theCustomer.firstName;
            cmd.Parameters.Add("@MName", SqlDbType.VarChar, 50).Value = theCustomer.lastName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar, 50).Value = theCustomer.middleName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = theCustomer.lastName;
            cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = theCustomer.adress2;
            cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = theCustomer.city;
            cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = theCustomer.state;
            cmd.Parameters.Add("@Zip", SqlDbType.Int).Value = theCustomer.zip;

            try
            {

                conn.Open();

                rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }


            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;

        }

    }
}