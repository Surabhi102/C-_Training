/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
      
   
   List<string> cars = new List<string>(){
       "Alto",
       "Inova",
       "Swift",
       "Vaganar",
       "Maruthi-800",
       "MaruthiOmni",
       "Creta"
   };
    
    string minValue = cars[0];
    string maxValue = cars[0];

    foreach (string car in cars )
    {
         if (car.Length < minValue.Length)
         {
              minValue = car;
         }
    }
  
    foreach (string car in cars )
    {
         if (car.Length > maxValue.Length)
         {
              maxValue = car;
         }
    }
     Console.WriteLine("The min value string {0}",minValue);
     Console.WriteLine("The max lenth string {0}",maxValue);
     
     Console.WriteLine("Cars with a");
            foreach(string term in cars)
            {
                if(term.Contains("a"))
                {
                    Console.Write(term+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cars with wif");
            foreach (string t in cars)
            {
                if (ter.Contains("wif"))
                {
                    Console.WriteLine(t);
                }
            }

   
  }
  
  
}

