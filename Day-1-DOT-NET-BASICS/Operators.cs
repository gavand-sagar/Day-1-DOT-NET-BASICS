using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class Operators
    {
        public static void Execute()
        {

            //string name = "sagar";
            //string name2 = name;
            //Console.WriteLine(name);
            //Console.WriteLine(name2);

            //Arithmetic Operators ----     + - * / %

            //int result =  13 / 5;
            //int rem = 13 % 5; // to check if a number is divisible by another number

            //Console.WriteLine(result);
            //Console.WriteLine(rem);




            ////
            /// Conditional Operators -- gives us a boolean result that we can check
            ////
            ///  <   >   <=     >=   ==     !=      !

            //bool result = 10 == 90;
            //Console.WriteLine(result);

            //bool opposite = !(1 > 2);
            //Console.WriteLine(opposite);



            // ternary operator    ? : 

            Console.WriteLine("Enter username");

            string username = Console.ReadLine();

            string dashboardVisibility = username == "Admin" ? "Yes" : "No";
            Console.WriteLine(dashboardVisibility);

            //bool dashboardVisibility = username == "Admin";
            // if username is Admin 
            // set dashboard visibily is true

        }
    }
}
