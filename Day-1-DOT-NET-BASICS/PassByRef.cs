using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class PassByRef
    {
        public static void Execute()
        {
            int number = 10; //value type

            Display(number);

            Console.WriteLine("in Execute method");
            Console.WriteLine(number);

        }

        public static void Display(int number)
        {
            number = 1000;
            Console.WriteLine("in display method");
            Console.WriteLine(number);
        }
    }
}
