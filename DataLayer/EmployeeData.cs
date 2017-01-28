using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Framework;
using Entities;

namespace DataLayer
{
   public  class EmployeeData
    {
        DataAccess dataAccess = new DataAccess();
        Employee emp = new Employee();
        public void insert(Employee employeeobj)
        {

            string insertQuery = "INSERT INTO point_of_sales.employee_table " +
                                    "(Employee_ID, Employee_Name, Employee_Password, Employee_Phone, Employee_Address, Employee_Type) " +
                                    "VALUES(@Employee_ID, @Employee_Name, @Employee_Password, @Employee_Phone, @Employee_Address,@Employee_Type)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery);

            MySqlParameter EmployeeIdParam = new MySqlParameter("@Employee_ID", MySqlDbType.Int64);
            EmployeeIdParam.Value = employeeobj.Employee_ID;

            MySqlParameter EmployeeNameParam = new MySqlParameter("@Employee_Name", MySqlDbType.VarChar, 50);
            EmployeeNameParam.Value = employeeobj.Employee_Name;

            MySqlParameter EmployeePasswordParam = new MySqlParameter("@Employee_Password", MySqlDbType.VarChar, 50);
            EmployeePasswordParam.Value = employeeobj.Employee_Password;

            MySqlParameter EmployeePhoneParam = new MySqlParameter("@Employee_Phone", MySqlDbType.VarChar, 50);
            EmployeePhoneParam.Value = employeeobj.Employee_Phone;

            MySqlParameter EmployeeAddressParam = new MySqlParameter("@Employee_Address", MySqlDbType.VarChar, 50);
            EmployeeAddressParam.Value = employeeobj.Employee_Address;

            MySqlParameter EmployeeType = new MySqlParameter("@Employee_Type", MySqlDbType.VarChar, 50);
            EmployeeType.Value = employeeobj.Employee_Type;

            insertCommand.Parameters.Add(EmployeeIdParam);
            insertCommand.Parameters.Add(EmployeePasswordParam); 
            insertCommand.Parameters.Add(EmployeePhoneParam);
            insertCommand.Parameters.Add(EmployeeType);
            insertCommand.Parameters.Add(EmployeeNameParam);
            insertCommand.Parameters.Add(EmployeeAddressParam);

            dataAccess.Execute(insertCommand);
        }

        public bool Login(string userName, string password)
        {
            string loginQuery = "SELECT * FROM employee_table WHERE Employee_Name = @ENAME AND Employee_Password = @EPASSWORD";

            MySqlCommand loginCommand = new MySqlCommand(loginQuery);

            MySqlParameter eNameParam = new MySqlParameter("@ENAME", MySqlDbType.VarChar, 50);
            eNameParam.Value = userName;

            MySqlParameter passwordParam = new MySqlParameter("@EPASSWORD", MySqlDbType.VarChar, 50);
            passwordParam.Value = password;

            loginCommand.Parameters.Add(eNameParam);
            loginCommand.Parameters.Add(passwordParam);

            DataTable dataTable = dataAccess.Query(loginCommand);

            if (dataTable.Rows.Count > 0) return true;

            return false;
        }
        public DataTable  show ()
        {
            string SQL = "SELECT Employee_Name, Employee_Phone, Employee_Type, Employee_Address FROM EMPLOYEE_TABLE";
            MySqlCommand command = new MySqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt ;

        }

    }
}
