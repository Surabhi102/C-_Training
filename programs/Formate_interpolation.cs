using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        private static void test()
        {
            string username = null;
            string password = null;

            Console.Write("Enter Username: ");
            username = Console.ReadLine();

            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            double charges = 5000; //5000
            DateTime dateTime = DateTime.Now;

            if (username == "raj" && password == "1234")
            {
                Console.WriteLine($"Hello {username}, We paid you Rs.{charges} on {dateTime.ToString("dd-MMM-yyyy")}");
                //Console.WriteLine(String.Format("{0:d}", dateTime));
            }
        }
    }
}

