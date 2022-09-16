using OOPs.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class LINQ
    {
        public static void Execute()
        {
            
            
            Customer[] customers = new Customer[5];
            customers[0] = new Customer() { DepartmentId = 1 };
            customers[1] = new SilverCustomer() { DepartmentId = 2 };
            customers[2] = new GoldCustomer() { DepartmentId = 2 };
            customers[3] = new SilverCustomer() { DepartmentId = 2 };
            customers[4] = new Customer() { DepartmentId = 3 };
            
            var result = customers
                .GroupBy(x => x.Discount)
                .Select(x =>
                        new
                        {
                            DeptId = x.Key,
                            Total = x.Count()
                        })
                .ToArray();
            
            Console.WriteLine("DeptId\tTotal");
            Console.WriteLine("=============");
            foreach (var item in result)
            {
                Console.WriteLine(item.DeptId + "\t" + item.Total);
            }

            Console.WriteLine("End");
            //Customer lowestDiscountCustomer = (from customer in customers
            //                                   orderby customer.Discount ascending
            //                                   select customer).FirstOrDefault();

            //Customer highestDiscountCustomer = (from customer in customers
            //                                    orderby customer.Discount descending
            //                                    select customer).FirstOrDefault();


            //var result = (from customer in customers
            //              where customer.Discount < 1000
            //              select new User()
            //              {
            //                  Username = customer.CustomerName,
            //              }).ToList();


            //Customer lowestDiscountedCustomer = new List<Customer>()
            //                                    .Where(x=> x.Id == 4).FirstOrDefault();

            //if (lowestDiscountedCustomer == null)
            //{
            //    Console.WriteLine("Its null");
            //}
            //else
            //{
            //    Console.WriteLine(lowestDiscountedCustomer.Discount);
            //}


        }
    }
}
