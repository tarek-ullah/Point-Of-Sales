using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Framework;
using Entities;

namespace DataLayer
{
    public class CatagoryData
    {
        DataAccess dataAccess = new DataAccess();

        public void Insert(Catagory catagoryobj)
        {
            string insertQuery = "INSERT INTO point_of_sales.catagory_table " + 
                                "(Catagory_ID, Catagory_Name, Catagory_Unit, Catagory_Description) " +
                                "VALUES(@Catagory_ID, @Catagory_Name, @Catagory_Unit, @Catagory_Description)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery);

            MySqlParameter CatagoryIdParam = new MySqlParameter("@Catagory_ID", MySqlDbType.Int64);
            CatagoryIdParam.Value = catagoryobj.Catagory_ID;

            MySqlParameter CatagoryNameParam = new MySqlParameter("@Catagory_Name", MySqlDbType.VarChar, 50);
            CatagoryNameParam.Value = catagoryobj.Catagory_Name;

            MySqlParameter CatagoryUnitParam = new MySqlParameter("@Catagory_Unit", MySqlDbType.Int64);
            CatagoryUnitParam.Value = catagoryobj.Catagory_Unit;

            MySqlParameter CatagoryDescParam = new MySqlParameter("@Catagory_Description", MySqlDbType.VarChar, 50);
            CatagoryDescParam.Value = catagoryobj.Catagory_Description;

            insertCommand.Parameters.Add(CatagoryIdParam);
            insertCommand.Parameters.Add(CatagoryNameParam);
            insertCommand.Parameters.Add(CatagoryUnitParam);
            insertCommand.Parameters.Add(CatagoryDescParam);

            dataAccess.Execute(insertCommand);
        }
        public DataTable showCatagory()
        {
            string SQL = "SELECT Catagory_Name, Catagory_Unit,Catagory_Description FROM CATAGORY_TABLE";
            MySqlCommand command = new MySqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }
    }
}
