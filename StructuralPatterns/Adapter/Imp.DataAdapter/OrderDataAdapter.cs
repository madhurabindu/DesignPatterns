using System;
using System.Data;
using Base.Interfaces;
using Imp.RemoteDataProvider;
using Imp.SqlDataProvider;

namespace Imp.DataAdapter
{
    public class OrderDataAdapter : IDataAccess
    {
        private SqlDataSource sqlDatabase;
        private RemoteService remoteService;

        public string DataType { get; private set; }

        public OrderDataAdapter(string dataType)
        {
            DataType = dataType;
            if(DataType == "sql")
            {
                sqlDatabase = new SqlDataSource();
            }
            else if(DataType == "remote")
            {
                remoteService = new RemoteService();
            }
        }
        public void ConnectToDataSource()
        {
            if(DataType == "sql")
            {
                string str = "Data Source=(local);Initial Catalog=Northwind;"
            + "Integrated Security=SSPI";
                sqlDatabase.ConnectToDatabase(str);
            }
            else if(DataType == "remote")
            {
                remoteService.Connect();
            }
        }

        public Order GetOrderData(string orderId)
        {
            Console.WriteLine("\nIn Adapter - Converting GetOrder Request to :{0}", DataType);
            Order data = null;

            if (DataType == "sql")
            {
                string queryString = string.Format("SELECT {0} FROM dbo.Orders;", orderId);
                IDataRecord record = sqlDatabase.GetOrderDetails(queryString);
                data = GetOrderFromDataRecord(record);
            }
            else if(DataType == "remote")
            {
                string jsonData = remoteService.GetOrderDetails(orderId);
                data = GetOrderFromJson(jsonData);
            }

            return data;
        }

       
        private Order GetOrderFromDataRecord(IDataRecord record)
        {
            Order p = null;
            if (record != null)
            {
                p = new Order()
                {
                    OrderId = (string)record[0],
                    ProductId = (string)record[1],
                    Quantity = (int)record[2]
                };
            }
            return p;
        }

        private Order GetOrderFromJson(string jsonData)
        {
            Order order = new Order();
            // Convert jsonString into a JSON object s=using a JSON deserializer
            // and convert the JSON object to ORDER data.
            return order;

        }

    }
}
