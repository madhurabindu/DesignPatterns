using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Base.Interfaces;

namespace Imp.SqlDataProvider
{
    public class SqlDataSource
    {
        private SqlConnection connection;
        public void ConnectToDatabase(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public IDataRecord GetOrderDetails(string queryString)
        {
            Console.WriteLine("In SQL Database Handler : Fetching the Data.........\n");
            return null;

            IDataRecord record = null;

            SqlCommand command = connection.CreateCommand();
            command.CommandText = queryString;
            command.CommandTimeout = 15;
            command.CommandType = CommandType.Text;

            command.Connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    record = (IDataRecord)reader;
                }
            }

            return record;
        }

       

    }
}
