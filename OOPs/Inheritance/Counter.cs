using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Inheritance
{
    public static class Counter
    {
        static int counter = 0;

        public static int GetCount()
        {
            return counter;
        }

        public static void Increment()
        {
            counter++;
        }
    }
}
