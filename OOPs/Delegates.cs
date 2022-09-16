using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Delegates
    {
        public static void Execute()
        {
            List<int> list = new List<int>() { 34, 56, 23, 12, 56, 7, 34, 65, 30, 31, 1, 43, 4, 67, 34, 3, 2, 123, 35, 43 };



            Console.WriteLine("sagar");

            // odd numbers 
            ShowFilteredData(list, IsOdd);

            //// even numbers
            ShowFilteredData(list, number => number % 2 == 0);

            ShowFilteredData(list, number => { return number % 2 == 0; });
            ShowFilteredData(list,
                (number) =>
                {
                    Console.WriteLine("number" + number);
                    return number % 2 == 0;
                });

            // 5 muliples only 
            ShowFilteredData(list, Is5Divisible);
        }

        private static bool Is5Divisible(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }

        private static void ShowFilteredData(List<int> list, Func<int, bool> checkingMethod)
        {
            foreach (int item in list)
            {
                if (checkingMethod(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
