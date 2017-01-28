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
    public class ProductData
    {
        DataAccess dataAccess = new DataAccess();
        public void insert(Product productobj)
        {

            string insertQuery = "INSERT INTO point_of_sales.product_table " +
                                    "(Product_ID,Unit_Cost,Product_Description,Stock, Supplier_ID,Product_Name,Catagory_ID,Unit_Price) " +
                                    "VALUES(@Product_ID,@Unit_Cost,@Product_Description,@Stock,@Supplier_ID,@Product_Name,@Catagory_ID,@Unit_Price)";

            MySqlCommand insertCommand = new MySqlCommand(insertQuery);

            MySqlParameter ProductIdParam = new MySqlParameter("@Product_ID", MySqlDbType.Int64);
            ProductIdParam.Value = productobj.Product_ID;

            MySqlParameter Unit_CostParam = new MySqlParameter("@Unit_Cost", MySqlDbType.Double);
            Unit_CostParam.Value = productobj.Unit_Cost;

            MySqlParameter ProductDescriptionParam = new MySqlParameter("@Product_Description", MySqlDbType.VarChar, 50);
            ProductDescriptionParam.Value = productobj.Product_Description;

            MySqlParameter StockParam = new MySqlParameter("@Stock", MySqlDbType.Int64);
            StockParam.Value = productobj.Stock;

            MySqlParameter SupplierIDParam = new MySqlParameter("@Supplier_ID", MySqlDbType.Int64);
            SupplierIDParam.Value = productobj.Supplier_ID;

            MySqlParameter ProductNameParam = new MySqlParameter("@Product_Name", MySqlDbType.VarChar, 50);
            ProductNameParam.Value = productobj.Product_Name;

            MySqlParameter CatagoryIDParam = new MySqlParameter("@Catagory_ID", MySqlDbType.Int64);
            CatagoryIDParam.Value = productobj.Catagory_ID;

            MySqlParameter UnitPriceParam = new MySqlParameter("@Unit_Price", MySqlDbType.Double);
            UnitPriceParam.Value = productobj.Unit_Price;

            insertCommand.Parameters.Add(ProductIdParam);
            insertCommand.Parameters.Add(Unit_CostParam);
            insertCommand.Parameters.Add(ProductDescriptionParam);
            insertCommand.Parameters.Add(StockParam);
            insertCommand.Parameters.Add(SupplierIDParam);
            insertCommand.Parameters.Add(ProductNameParam);
            insertCommand.Parameters.Add(CatagoryIDParam);
            insertCommand.Parameters.Add(UnitPriceParam);
            dataAccess.Execute(insertCommand);
        }
        public DataTable idMatchedProducts( Int32 arg_id)
        {
            
            string IDQuery = "SELECT Product_ID, Product_Name,Stock,Unit_Price,Unit_Cost FROM product_table WHERE Product_ID=@ID";

            MySqlCommand IDCommand = new MySqlCommand(IDQuery);

            MySqlParameter IDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
            IDParam.Value = arg_id;

            IDCommand.Parameters.Add(IDParam);

            DataTable dataTable = dataAccess.Query(IDCommand);

            return dataTable;
        }
        public DataTable showProducts()
        {
            string SQL = "SELECT Product_ID, Product_Name,Stock,Unit_Price,Unit_Cost FROM PRODUCT_TABLE";
            MySqlCommand command = new MySqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }
        public void updateProducts(Int64 stock_value ,Int32 to_update_id )
        {
            string updateQuery = "update product_table set Stock=@Stock where Product_ID=@ID";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery);

            MySqlParameter IDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
            IDParam.Value = to_update_id;

            updateCommand.Parameters.Add(IDParam);
            MySqlParameter stockParam = new MySqlParameter("@Stock",MySqlDbType.Int64);
            stockParam.Value = stock_value;

            updateCommand.Parameters.Add(stockParam);
            dataAccess.updateDatabase(updateCommand);
        }


    }
}
