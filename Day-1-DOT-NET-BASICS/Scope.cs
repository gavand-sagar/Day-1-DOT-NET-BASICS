using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class Scope
    {
        public static void Execute()
        {
            int number = 10; // declaration + initialization
            bool status = true;

            object message = "SagaR"; // declaration 

            string newString = (string)message;


            //object objNumber = number;


            //object objNumber = number;

            ////var is not any dataType
            //int something = number;

            
            if (number == 0)
            {
                message = "its zero"; // assignment                
                Console.WriteLine(message);
            }
            else
            {
                message = "its not zero";
                Console.WriteLine(message);
            }


        }
    }
}
