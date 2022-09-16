using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderManagementV1 : IOrderManagement
    {
        public void AddOrder(string productId, string userId)
        {
            Console.WriteLine("order placed V1");
        }
    }

    public class OrderManagementV2 : IOrderManagement
    {
        public void AddOrder(string productId, string userId)
        {
            //
            Console.WriteLine("product details blah blah blah!!!  order placed V2");
        }
    }

    public class OrderManagementV3 : IOrderManagement
    {
        public void AddOrder(string productId, string userId)
        {
            //
            Console.WriteLine($"order placed for {productId} by {userId}");
        }
    }
}
