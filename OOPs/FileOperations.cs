using OOPs.Inheritance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class FileOperations
    {

        public static void Execute()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(desktopPath);

            //var stream = File.Open(desktopPath + @"\myFile.txt", FileMode.OpenOrCreate);
            //BinaryFormatter b = new BinaryFormatter();
            //Customer customer = new Customer();
            //customer.CustomerName = "Sagar";
            //customer.dob = DateTime.Now;
            //b.Serialize(stream, customer);
            //stream.Close();


            //var stream = File.Open(desktopPath + @"\myFile.txt", FileMode.OpenOrCreate);
            //BinaryFormatter b = new BinaryFormatter();
            //Customer c = (Customer)b.Deserialize(stream);
            //stream.Close();


            //string previousData = File.ReadAllText(path);

            //int.TryParse(previousData, out int count);

            //int i;
            //for (i = count; i < count + 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //File.WriteAllText(path, i.ToString());

        }
    }
}
