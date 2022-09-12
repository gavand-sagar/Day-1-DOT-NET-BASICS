using OOPs.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Generics
    {

        public static void Execute()
        {
            //int x = 100;  //value type

            //int y = 800;

            //Console.WriteLine($"x = {x}  and y = {y}");

            //Swap(ref x, ref y);

            //Console.WriteLine($"x = {x}  and y = {y}");


            //double x = 56.5;  //value type

            //double y = 70.9;

            //Console.WriteLine($"x = {x}  and y = {y}");



            //SilverCustomer c1 = new SilverCustomer();
            //Customer c2 = new Customer();


            //Swap(c1, c1);

            //Console.WriteLine($"x = {x}  and y = {y}");


            // Generic collection //

            //List<Customer> users = new List<Customer>();

            //users.Add(new Customer());
            //users.Add(new Customer());
            //users.Add(new Customer());
            //users.Add(new Customer());

            //List<string> list = new List<string>();

            //MyGenericMethodToAdd(list, "sagar");


            //GenericWithTwoValues<int, bool>(true, true, 89, "", 56);
            //GenericWithTwoValues<string,string>("", "", "", "", "");


            //User[] values = new User[5];

            //User u = new User();
            //u.Username = "Sagar";

            //values["E0010"] = u;
            //values["E0011"] = u;
            //values["E0011"] = u;


            //int key = 3;
            //User u1 = values[key];


            //Dictionary<string, User> values = new Dictionary<string, User>();

            //User u = new User();

            //values.Add("E0010", u);

            //values.Add("E0010", u);

            //values.Add("E0010", u);

            //values.Add("E0010", u);

            // 3 is a key for sagar




          

            Console.WriteLine("Enter a choice : ");
            Console.WriteLine("1.regular");
            Console.WriteLine("2.silver");
            Console.WriteLine("3.gold");

            string input = Console.ReadLine();

            Customer customer = GetCustomer(input);

            List<Customer> list = new List<Customer>();
            list.Add(customer);

            customer.Display();


        }

        public static Customer GetCustomer(string type)
        {
            Dictionary<string, Customer> keyValuePairs = new Dictionary<string, Customer>();
            keyValuePairs.Add("regular", new Customer());
            keyValuePairs.Add("silver", new SilverCustomer());
            keyValuePairs.Add("gold", new GoldCustomer());

            return keyValuePairs[type];
        }

        public static void GenericWithTwoValues<P, T>(T value1, T value2, P value3, string value4, P value5)
        {

        }

        //public static void MyGenericMethodToAdd<T>(IList<T> list, T item)
        //{
        //    list.Add(item);
        //}

        //public static void Swap<Type>(Type a, Type b) where Type : class
        //{

        //}
    }
}
