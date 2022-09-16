using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public enum TypeOfOperation
    {
        silver = 56,
        gold = 89,
        diamond = 45
    }
    internal static class Enum
    {
        //name-integer constant // flags

        public const string Name = "Sagar"; //
        public readonly static string LastName = "Gavand"; // run - time

        //public Enum()
        //{
        //    LastName = "gavand";
        //    //Name = "sagar";
        //}

        //public Enum(string lastname)
        //{
        //    LastName = lastname;
        //    //Name = "sagar";
        //}

        public static void ReadonlyTest()
        {
            //Name = "sagar";
            //LastName = "gavand";
        }






       

        public static void Execute()
        {



            //TypeOfOperation flag = TypeOfOperation.silver;

            int? number = null;

            float? value = null;

            bool? temp = null;

        }

        public static void DisplaySomething(TypeOfOperation type)
        {
            if (type == TypeOfOperation.gold)
            {

            }
            else if (type == TypeOfOperation.silver)
            {

            }
            else if (type == TypeOfOperation.diamond)
            {

            }
        }




    }
}
