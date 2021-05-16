/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Globalization;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    stringformattingandinterpolation();
  }
  
    private static void stringformattingandinterpolation()
        {
            //formatting

            int year = 2001;
            string auth = "Bary B Brey";
            string bookName = "Microprocessor";
            decimal rate = 1500m;
            string publisher = "MCH";

            string bookDetails = string.Format("{0} has authored book {1}" +
            "and is published by {2} in {3}. Book rate is Rs.{4}. ", auth, bookName, 
            publisher, year, rate);

            Console.WriteLine(bookDetails);

            // Number formatting  
            int num = 302;
            string numStr = String.Format("Number {0, 0:D4}", num);
            Console.WriteLine(numStr);

            // Decimal formatting  
            decimal money = 99.95m;
            String strMoney = string.Format(new CultureInfo("en-IN"), "{0:c}", money);
            Console.WriteLine(strMoney);

            // DateTime formatting  
            DateTime dateNow = DateTime.Now;
            string dtStr = String.Format("{0:t} at {0:d}", dateNow);
            Console.WriteLine(dtStr);

            //interpolation

            string fName = "Ravi";
            string lName = "Ram";
            int day = 1;

            string strWelcomeMessage =String.Format("Hello {fName} {lName}, We welcome you to Day {day}!",fName,lName,day);
            Console.WriteLine();
        }
}

