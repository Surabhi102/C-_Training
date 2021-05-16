using System;
using Class;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            int[] a = { 1, 2, 1, 3, 2, 4, 5, 4, 5 };

            int res = (int)math.Pair(a);
            Console.WriteLine(res);


           

        }

    }
}
