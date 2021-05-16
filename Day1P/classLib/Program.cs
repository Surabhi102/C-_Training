using class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            float sub = math.subtract(7, 9);
            float mul = math.multiply(9, 9);
            float div = math.divide(9, 3);
            float ad = math.add(9, 8);
            Console.WriteLine(sub + " " + mul + " " + div + " " + ad + " ");
        }
    }
}
