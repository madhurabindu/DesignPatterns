using System;

namespace Imp.RemoteDataProvider
{
    public class RemoteService
    {
        public string GetOrderDetails(string orderId)
        {
            Console.WriteLine("In REMOTE Service Handler : Fetching the Data.........\n");

            // get the data from a remote service and return JSON data
            return string.Empty;
        }

        public void Connect()
        {
        }
    }
}
