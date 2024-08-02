using System;

namespace Base.Interfaces
{
    public interface IDataAccess
    {
        void ConnectToDataSource();

        Order GetOrderData(string orderId);
    }

    public class Order
    {
        public string OrderId { get; set; }
        public string  ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
