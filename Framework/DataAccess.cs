using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Framework
{
    public class DataAccess
    {
        string connectionString = "server=127.0.0.1;user id=root; password=root;database=point_of_sales";

        public void Execute(MySqlCommand command)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Query(MySqlCommand command)
        {
            DataTable dataTable = new DataTable();

            MySqlConnection connection = new MySqlConnection(connectionString);
            command.Connection = connection;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
        public void updateDatabase(MySqlCommand command)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);
            command.Connection = connection;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();
        } 
    }
}
