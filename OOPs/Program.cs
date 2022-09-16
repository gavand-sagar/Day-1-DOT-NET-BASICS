using OOPs.Inheritance;
using System;
using System.Collections.Generic;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Enum.Execute();

            try
            {
                Exceptions.Execute();
            }
            catch (Exception)
            {
                //
                Console.WriteLine("there is an error in application");
                //there was some code here
            }

            Console.ReadLine();
        }










        private static void UniqueValues()
        {
            int[] numbers = GetNumbersFromUser();

            Console.WriteLine("Following are unique values");
            Console.WriteLine("===========================");
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int result = GetOccuranceCount(numbers, currentNumber);

                if (result == 1)
                {
                    Console.WriteLine(currentNumber);
                }

            }
        }

        private static int[] GetNumbersFromUser()
        {
            Console.WriteLine("Give limit of Array");
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];
            Console.WriteLine("Type every number");

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;

        }

        //STUB // 
        private static int GetOccuranceCount(int[] numbers, int currentNumber)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
