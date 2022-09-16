using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Interfaces
    {
        static IOrderManagement orderManagement;
        public static void Execute()
        {

            Console.WriteLine("Enter Product Id");
            string productId = Console.ReadLine();

            Console.WriteLine("Enter User Id");
            string userId = Console.ReadLine();

            orderManagement.AddOrder(productId, userId);

        }
    }
}
