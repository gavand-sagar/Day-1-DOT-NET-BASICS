using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Exceptions
    {
        public static void Execute()
        {

            //Arithmatic Exception
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                int res = num1 / num2;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Can't divide by zero try again!");
                Execute();
            }


            Console.WriteLine("Program ended successfully.");


            //Array Out of bound exception
            int[] num = new int[5];
            for (int i = 0; i < 6; i++)
            {
                if (i < num.Length)
                {
                    Console.WriteLine(num[i]);
                }
            }

            //file format exception
            string s = "sanket";
            int a = int.Parse(s);

            //Null reference exception
            string s1 = null;

            if (s1 != null)
            {
                Console.WriteLine(s1.Length);
            }

            //Argument Exception
            string path = "";
            File.WriteAllText(path, "");


        }
    }
}
