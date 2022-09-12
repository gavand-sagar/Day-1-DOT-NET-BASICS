using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class Loops
    {
        public static void Execute()
        {
            //int limit = 5;

            //string output = "";

            //int couter = 1;
            //while (couter <= limit)
            //{
            //    // will execute 6 time
            //    output = output + "apple";
            //    couter++;
            //}
            //Console.WriteLine(output);


            //int limit = 5;
            //string output = "";
            //int couter = 1;
            //do
            //{
            //    // will execute 6 time
            //    output = output + "apple";
            //    couter++;
            //}
            //while (couter <= limit);
            //Console.WriteLine(output);

            //string choice = "N";

            //do
            //{
            //    int number = GetIntegerFromConsole("Enter a number");
            //    Console.WriteLine("Its sqaure root is " + Math.Sqrt(number));


            //    Console.WriteLine("Do you want to repeat the program? (Y/N)");
            //    choice = Console.ReadLine();
            //}
            //while (choice == "Y");


            //int value = GetIntegerFromConsole("Enter Number  - 1");
            //Console.WriteLine("Number1  " + value);

            //int value2 = GetIntegerFromConsole("Enter Number - 2");
            //Console.WriteLine("Number - 2  " + value2);


            //for (int i = 10; i <= 15; i++)
            //{
            //    Console.WriteLine($"{i} Welcome");
            //}
            

        }




        public static int GetIntegerFromConsole(string msg)
        {
            bool validConversionOrNOt = false;
            int value = 0;

            while (validConversionOrNOt == false)
            {
                Console.WriteLine(msg);
                string nubmer = Console.ReadLine();

                validConversionOrNOt = int.TryParse(nubmer, out value);

            }

            return value;
        }

        //public static int GetIntegerFromConsole(string msg)
        //{
        //    bool validConversionOrNOt = false;
        //    int value = 0;

        //    Console.WriteLine(msg);
        //    string nubmer = Console.ReadLine();
        //    validConversionOrNOt = int.TryParse(nubmer, out value);

        //    if (validConversionOrNOt == false)
        //    {
        //        return GetIntegerFromConsole(msg);
        //    }
        //    else
        //    {
        //        return value;
        //    }            

        //}
    }
}
