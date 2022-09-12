using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Inheritance
{
    // customer -> base or parent
    // silver ----> derived or child
    internal class SilverCustomer : Customer
    {
        public SilverCustomer()
        {  
            _discount = 30;
        }
        public override void Display()
        {
            Console.WriteLine("Its a Silver");
        }
    }
}
