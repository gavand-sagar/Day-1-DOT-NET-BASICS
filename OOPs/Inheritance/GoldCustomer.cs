using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Inheritance
{
    // customer -> base or parent
    // gold ----> derived or child
    internal class GoldCustomer : Customer
    {
        public string VIPPassID { get; set; }

        public GoldCustomer()
        {

            _discount = 40;
        }

        public override void Display()
        {
            Console.WriteLine("Its a gold");
        }

    }
}
