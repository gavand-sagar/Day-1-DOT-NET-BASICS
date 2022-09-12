using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            Initialize();
        }

        public void Initialize()
        {
            Console.WriteLine("Enter User Details");
            Console.WriteLine("==================");
            
            Console.WriteLine("Enter Username");
            Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
        }

        public bool Authenticate()
        {
            if (Username == "Admin" && Password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Information");
            Console.WriteLine("=================");
            Console.WriteLine("Usernam : " + Username);
            Console.WriteLine("Password : " + Password);
        }
    }
}
