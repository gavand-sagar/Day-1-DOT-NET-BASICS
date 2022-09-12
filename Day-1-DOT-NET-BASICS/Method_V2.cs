using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_DOT_NET_BASICS
{
    internal class Method_V2
    {
        public static void Execute()
        {
            string result = Append("Apple", "grape");
            Console.WriteLine(result);
        }

        //public static string Append(string first, string last)
        //{
        //    //string final = first + " " + last;
        //    string final = $"{first} {last}";
        //    return final;
        //}

        //default parameter
        public static string Append(string first, string middle, string last = "temp")
        {
            //string final = first + " " + last;
            string final = $"{first} {middle} {last}";
            return final;
        }


    }
}
