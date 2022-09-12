using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class Methods
    {
        static int number = 10;
        static Methods()
        {
            Console.WriteLine("welcome");
        }
        public static void Execute()
        {
            //Display Greeting message
            Console.WriteLine("Hi, good evening!!");

            //calculate sum of 1000 + 5000

            int value = NewMethod();           

            //Display a good bye message
            Console.WriteLine("Good bye");

            Console.WriteLine(value);

        }

        private static int NewMethod()
        {
            Console.WriteLine("Enter number 1 : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
                        
            int sum = input1 + input2;
            
            return sum;                        
        }
    }
}
