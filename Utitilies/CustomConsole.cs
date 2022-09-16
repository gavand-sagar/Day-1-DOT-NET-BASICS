using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utitilies
{
    public class CustomConsole
    {
        public static int ReadInteger(string msg)
        {
            Console.WriteLine(msg);
            bool result = int.TryParse(Console.ReadLine(), out int val);
            if (result)
            {
                return val;
            }
            else
            {
                Console.WriteLine("Invalid Entry :");
                return ReadInteger(msg);
            }
        }
    }
}
