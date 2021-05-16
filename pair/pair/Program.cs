using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pair
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 3, 2, 4, 5 };


        }
        public int pair(int[] nums)
        {
           
            int cnt = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i = i + 2)
            {
                if (nums[i] == nums[i + 1])
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine(cnt);

        }
    }
}
