using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.to print the hello world
            //print();

            //2,datatype 
            //datatype();

            //3.Type Cating 
            //typecasting();

            //4.Collection
            // collection();

            //5.stringformate
            //stringformate();

            //6. String Interpolation
            //interpolation();

            //7. Exception try and catch statements
            //exception();

            //8. CollectionExercise to create a list of cars and to print 
            //a. min_length, b. max_length, c. with "wif", d. 'a'
            //exersice();



        }    
        public static void print()
        {
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
        public static void dataype()
        {
            int myNum = 5;               // integer (whole number)
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
        }
        public static void typecasting()
        {
            //implicit typecating char -> int -> long -> float -> double(automatic
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //explicit typecating double -> float -> long -> int -> char(manually)
            double myDoubl = 9.78;
            int myIn = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDoubl);   // Outputs 9.78
            Console.WriteLine(myIn);      // Outputs 9

            int inti = 10;
            double myDoub = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(inti));    // convert int to string
            Console.WriteLine(Convert.ToDouble(inti));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoub));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


        }
        public static void collection()
        {
            // Creating a List of integers
            List<int> mylist = new List<int>();

            // adding items in mylist
            for (int j = 5; j < 10; j++)
            {
                mylist.Add(j * 3);
            }

            // Displaying items of mylist
            // by using foreach loop
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }
        }
        public static void stringformate()
        {
            Decimal pricePerOunce = 17.36m;
            String s = String.Format("The current price is {0} per ounce.",
                                     pricePerOunce);
            Console.WriteLine(s);
        }

        public static void interpolation()
        {
            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
          


        }

        public static void exception()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
