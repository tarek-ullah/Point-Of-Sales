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
   public class SupplierData
    {
        DataAccess dataAccess = new DataAccess();
        public void insert(Supplier supplierobj)
        {

            string insertQuery = "INSERT INTO point_of_sales.supplier_table " +
                                    "(Supplier_ID, Supplier_Name, Supplier_Email,Supplier_Phone) " +
                                    "VALUES(@Supplier_ID, @Supplier_Name, @Supplier_Email,@Supplier_Phone)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery);

            MySqlParameter SupplierIdParam = new MySqlParameter("@Supplier_ID", MySqlDbType.Int64);
            SupplierIdParam.Value = supplierobj.Supplier_ID;

            MySqlParameter SupplierNameParam = new MySqlParameter("@Supplier_Name", MySqlDbType.VarChar, 50);
            SupplierNameParam.Value = supplierobj.Supplier_Name;

            MySqlParameter SupplierEmailParam = new MySqlParameter("@Supplier_Email", MySqlDbType.VarChar, 50);
            SupplierEmailParam.Value = supplierobj.Supplier_Email;

            MySqlParameter SupplierPhoneParam = new MySqlParameter("@Supplier_Phone", MySqlDbType.VarChar, 50);
            SupplierPhoneParam.Value = supplierobj.Supplier_Phone;
          
            insertCommand.Parameters.Add(SupplierIdParam);
            insertCommand.Parameters.Add(SupplierNameParam);
            insertCommand.Parameters.Add(SupplierEmailParam);
            insertCommand.Parameters.Add(SupplierPhoneParam);
            dataAccess.Execute(insertCommand);
        }
        public DataTable showSupplier()
        {
            string SQL = "SELECT Supplier_Name,Supplier_Email,Supplier_Phone FROM SUPPLIER_TABLE";
            MySqlCommand command = new MySqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

    }
}
