using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void studentinfo()
        {
            var sut1 = new student(1, "sita", "mysore", 21);
            var sut2 = new student(2, "rita", "delhi", 21);
            var sut3 = new student(3, "geeta", "mysore", 21);
            var sut4 = new student(4, "hema", "mumbai", 21);
            var sut5 = new student(5, "mega", "mysore", 21);
            var sut6 = new student(6, "hita", "kanpur", 21);
            var sut7 = new student(7, "priya", "Hassan", 21);
            var sut8 = new student(8, "tia", "mysore", 21);
            var sut9 = new student(9, "Pya", "Ballary", 21);
            var sut10 = new student(10, "safa", "mysore", 21);
            var students = new List<student>
                {
              sut1,
              sut2,
              sut3,
              sut4,
              sut5,
              sut6,
              sut7,
              sut8,
              sut9,
              sut10,
                };
            var res = from stu in students
                      where stu.City.Contains("a") || stu.City.Contains("m") 
                      orderby stu.Name descending
                      select stu;

            foreach (student s in res)
                Console.WriteLine(s.Id+" "+ s.Name+" "+s.City+" "+ s.Age);
        }
    }
}
