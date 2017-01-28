using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using MySql.Data.MySqlClient;
using MySql.Data;
using Framework;
using Entities;
using MySql.Data.Common;
using System.Data.SqlClient;
using System.Data;


namespace DataLayer
{
   public  class CustomerData
    {
        DataAccess dataAccess = new DataAccess();

        public void Insert(Customer customerobj)
        {
            string insertQuery = "INSERT INTO point_of_sales.customer_table " +
                                "( Customer_ID, Customer_Name, Customer_Phone, Customer_Address, Customer_Email) " +
                                "VALUES(@Customer_ID, @Customer_Name, @Customer_Phone, @Customer_Address, @Customer_Email)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery);

            MySqlParameter CustomerIdParam = new MySqlParameter("@Customer_ID", MySqlDbType.Int64);
            CustomerIdParam.Value = customerobj.Customer_ID;

            MySqlParameter CustomerNameParam = new MySqlParameter("@Customer_Name", MySqlDbType.VarChar, 50);
            CustomerNameParam.Value = customerobj.Customer_Name;

            MySqlParameter CustomerPhoneParam = new MySqlParameter("@Customer_Phone", MySqlDbType.VarChar,50);
            CustomerPhoneParam.Value = customerobj.Customer_Phone;

            MySqlParameter CustomerAddressParam = new MySqlParameter("@Customer_Address", MySqlDbType.VarChar, 50);
            CustomerAddressParam.Value = customerobj.Customer_Address;

            MySqlParameter CustomerEmailParam = new MySqlParameter("@Customer_Email", MySqlDbType.VarChar, 50);
            CustomerEmailParam.Value = customerobj.Customer_Email;

            insertCommand.Parameters.Add(CustomerIdParam);
            insertCommand.Parameters.Add(CustomerNameParam);
            insertCommand.Parameters.Add(CustomerPhoneParam);
            insertCommand.Parameters.Add(CustomerAddressParam);
            insertCommand.Parameters.Add(CustomerEmailParam);

            dataAccess.Execute(insertCommand);
   
            
        }
        public DataTable showCustomer()
        {
            string SQL = "SELECT * FROM CUSTOMER_TABLE";
            MySqlCommand command = new MySqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

      }
    }
    
}
