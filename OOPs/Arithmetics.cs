using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utitilies;

namespace OOPs
{
    internal class Arithmetics
    {
        public static void Execute()
        {
            int number = CustomConsole.ReadInteger("Enter a number : ");

            Console.WriteLine(number * number);
        }
    }
}
