using OOPs.Inheritance;
using System;
using System.Collections.Generic;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Discount);

            //SilverCustomer silverCustomer = new SilverCustomer();
            //Console.WriteLine(silverCustomer.Id);
            //Console.WriteLine(silverCustomer.Discount);

            //GoldCustomer goldCustomer = new GoldCustomer();
            //Console.WriteLine(goldCustomer.Id);
            //Console.WriteLine(goldCustomer.Discount);

            //goldCustomer.dob = DateTime.Parse("1981-05-02");
            //Console.WriteLine(goldCustomer.Age);



            //List<Customer> customers= new List<Customer>();

            //customers.Add(new Customer());
            //customers.Add(new SilverCustomer());
            //customers.Add(new GoldCustomer());

            //foreach (Customer item in customers)
            //{
            //    Console.WriteLine(item.Discount);
            //}
            Generics.Execute();

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
